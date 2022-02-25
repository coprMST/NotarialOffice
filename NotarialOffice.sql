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
select HASHBYTES('SHA2_512', 'aboba')

insert into Accounts (Password) values (HASHBYTES('SHA2_512', 'aboba'))



select AccountID from Accounts where Password = HASHBYTES('SHA2_512', 'aboba')

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






insert into Accounts(PhoneNumber, Email, Password)
values
('33', 'abobus@mail.ru', HASHBYTES('SHA2_512', 'abobus'))
go

create function [dbo].[GetCustomer](@phoneNumber numeric(38), @email varchar(800), @password varchar(64))
returns table
as
	return
	select A.AccountID, C.CustomerID, C.LastName, C.FirstName, C.MiddleName
	from Accounts A inner join Customers C on A.AccountID = C.AccountID 
	where (PhoneNumber = @phoneNumber or Email = @email) and Password = HASHBYTES('SHA2_512', @password)
go
select* from [dbo].[GetCustomer]('88005553535', null, 'abobus')


create function [dbo].[GetEmployee](@phoneNumber numeric(38), @email varchar(800), @password varchar(64))
returns table
as
	return
	select A.AccountID, E.EmployeeID, E.LastName, E.FirstName, E.MiddleName
	from Accounts A inner join Employees E on A.AccountID = E.AccountID 
	where (PhoneNumber = @phoneNumber or Email = @email) and Password = HASHBYTES('SHA2_512', @password)
go
select* from [dbo].[GetEmployee]('8800555335', null, 'abobus')





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

