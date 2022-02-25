create database [NotarialOffice]
go

use [NotarialOffice]
go

create function [dbo].[AgeCheck] (@dateOfBith date, @age int)
returns bit
begin
return case when datediff(day, dateadd(year, @age, @dateOfBith), sysdatetime()) > 0 then 1 else 0 end
end
go

create table [dbo].[Positions] (
	[PositionID] integer primary key identity ,
	[PositionName] varchar(800) unique not null,
	[Salary] decimal(19,2) check ([Salary] >= 0) not null,
	[Responsibilities] varchar(max) null,
)
go

create table [dbo].[Accounts] (
	[AccountID] uniqueidentifier primary key default newid(),
    [PhoneNumber] numeric(38) unique not null,
	[Email] varchar(800) unique not null,
	[Password] varbinary(64) not null,
	[DateOfRegistration] datetime2(3) default sysdatetime(),
)
go

create table [dbo].[Employees] (
	[EmployeeID] uniqueidentifier primary key default newid(),
	[AccountID] uniqueidentifier foreign key references [dbo].[Accounts]([AccountID]) on delete cascade on update cascade not null,
	[PositionID] integer foreign key references [dbo].[Positions]([PositionID]) on delete no action on update cascade not null,
	[LastName] varchar(800) not null,
    [FirstName] varchar(800) not null,
	[MiddleName] varchar(800) null,
	[DateOfBith] date check ([dbo].[AgeCheck]([DateOfBith], 18) = 1) not null,
)
go

create table [dbo].[Customers] (
    [CustomerID] uniqueidentifier primary key default newid(),
	[AccountID] uniqueidentifier foreign key references [dbo].[Accounts]([AccountID]) on delete cascade on update cascade not null,
    [LastName] varchar(800) not null,
    [FirstName] varchar(800) not null,
	[MiddleName] varchar(800) null,
	[DateOfBith] date check ([dbo].[AgeCheck]([DateOfBith], 14) = 1) not null,
)
go


create trigger Un1
on [dbo].[Employees]
for insert, update
as 
	if exists (select AccountID from Customers where AccountID = (select AccountID from inserted))
	begin
	rollback transaction
	end
go

create trigger Un2
on [dbo].[Customers]
for insert, update
as 
	if exists (select AccountID from Employees where AccountID = (select AccountID from inserted))
	begin
	rollback transaction
	end
go



create procedure [dbo].[GetCustomer](@phoneNumber numeric(38), 
									 @email varchar(800), 
									 @password varchar(64))
as
	select A.AccountID, C.CustomerID, C.LastName, C.FirstName, C.MiddleName
	from Accounts A inner join Customers C on A.AccountID = C.AccountID 
	where (PhoneNumber = @phoneNumber or Email = @email) and Password = HASHBYTES('SHA2_512', @password)
go

exec [dbo].[GetCustomer] 3333333, null, 22222
go

create procedure [dbo].[GetEmployee](@phoneNumber numeric(38), 
									 @email varchar(800), 
									 @password varchar(64))
as
	select A.AccountID, E.EmployeeID, E.LastName, E.FirstName, E.MiddleName
	from Accounts A inner join Employees E on A.AccountID = E.AccountID 
	where (PhoneNumber = @phoneNumber or Email = @email) and Password = HASHBYTES('SHA2_512', @password)
go

--exec [dbo].[GetEmployee] '8800555335', null, 'abobus'
--go

create procedure [dbo].[AddNewCustomer] (@lastName varchar(800), 
										 @firstName varchar(800), 
										 @middleName varchar(800), 
										 @dob date, 
										 @phone numeric(38), 
										 @email varchar(800), 
										 @password varchar(64))
as
	declare @IDs table(ID uniqueidentifier)
	
	if not exists (select PhoneNumber, Email from Accounts where PhoneNumber = @phone or Email = @email)
	begin
		insert into [dbo].[Accounts](PhoneNumber, Email, Password)
		output inserted.AccountID into @IDs
		values (@phone, @email, HASHBYTES('SHA2_512', @password))
		
		insert into [dbo].[Customers](AccountID, LastName, FirstName, MiddleName, DateOfBith)
		output inserted.CustomerID into @IDs
		values ((select top 1 ID from @IDs), @lastName, @firstName, @middleName, @dob)

		select ID from @IDs
	end
go

--exec [dbo].[AddNewCustomer] 'wda2wd', 'awd2a2wd', 'awda2wd', '1.1.2000', '3333333', '233333', '22222' 
--go


create procedure [dbo].[CheckPhoneAndEmail] (@phone numeric(38), 
											 @email varchar(800))
as
	declare @boolean table(bool bit)
	declare @check bit
	
	set @check = case when exists (select PhoneNumber, Email from Accounts where PhoneNumber = @phone or Email = @email) then 1 else 0 end
	
	if (@check = 1)
	begin
		insert @boolean values ('1')
	end
	else
	begin
		insert @boolean values ('0')
	end

	select* from @boolean
go

--exec [dbo].[CheckPhoneAndEmail] '88005553535', 'b3ashkir@mail.ru' 
--go









create table [dbo].[DocumentTypes] (
	[DocumentTypeID] smallint identity primary key,
	[DocumentName] varchar(800) unique not null,
	[Tariff] decimal(19,2) check ([Tariff] >= 0) null,
	[FirstPrice] decimal(19,2) check ([FirstPrice] >= 0) null,
	[SecondPrice] decimal(19,2) check ([SecondPrice] >= 0) null,
	[Comment] varchar(max) null,
)
go

create table [dbo].[AdditionsForDocumentTypes] (
	[AdditionForDocumentTypeID] smallint identity primary key,
	[DocumentTypeID] smallint foreign key references [dbo].[DocumentTypes]([DocumentTypeID]) on delete cascade on update cascade not null,
	[AdditionName] varchar(800) not null,
	[Tariff] decimal(19,2) check ([Tariff] >= 0) null,
	[FirstPrice] decimal(19,2) check ([FirstPrice] >= 0) null,
	[SecondPrice] decimal(19,2) check ([SecondPrice] >= 0) null,
	[Comment] varchar(max) null,
)
go

insert into [dbo].[DocumentTypes]([DocumentName], [Tariff], [FirstPrice], [SecondPrice])
values
('Завещание на все имущество', '100', '1900', NULL),
('Завещание на часть имущества', '100', '1900', NULL)
go

insert into [dbo].[AdditionsForDocumentTypes]([DocumentTypeID], [AdditionName], [Tariff], [FirstPrice], [SecondPrice])
values
('1', 'Принятие закрытого завещания', '100', '1900', NULL),
('1', 'Вскрытие конверта с закрытым завещанием и оглашение закрытого завещания', '300', '2200', NULL),
('2', 'Принятие закрытого завещания', '100', '1900', NULL),
('2', 'Вскрытие конверта с закрытым завещанием и оглашение закрытого завещания', '300', '2200', NULL)
go

