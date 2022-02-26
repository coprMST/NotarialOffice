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
	[DateOfBith] date check ([dbo].[AgeCheck]([DateOfBith], 18) = 1) not null,
)
go


create trigger UniqueEmployees
on [dbo].[Employees]
for insert, update
as 
	if exists (select AccountID from Customers where AccountID = (select AccountID from inserted))
		rollback transaction
go

create trigger UniqueCustomers
on [dbo].[Customers]
for insert, update
as 
	if exists (select AccountID from Employees where AccountID = (select AccountID from inserted))
		rollback transaction
go



create procedure [dbo].[GetCustomer](@phoneNumber numeric(38), 
									 @email varchar(800), 
									 @password varchar(64))
as
	select A.AccountID, C.CustomerID, C.LastName, C.FirstName, C.MiddleName
	from Accounts A inner join Customers C on A.AccountID = C.AccountID 
	where (PhoneNumber = @phoneNumber or Email = @email) and Password = HASHBYTES('SHA2_512', @password)
go

--exec [dbo].[GetCustomer] 3333333, null, 22222
--go

create procedure [dbo].[GetEmployee](@phoneNumber numeric(38), 
									 @email varchar(800), 
									 @password varchar(64))
as
	select A.AccountID, E.EmployeeID, E.LastName, E.FirstName, E.MiddleName
	from Accounts A inner join Employees E on A.AccountID = E.AccountID 
	where (PhoneNumber = @phoneNumber or Email = @email) and Password = HASHBYTES('SHA2_512', @password)
go

--exec [dbo].[GetEmployee] 8800555335, null, abobus
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
		set xact_abort on	
		begin tran
		insert into [dbo].[Accounts](PhoneNumber, Email, Password)
		output inserted.AccountID into @IDs
		values (@phone, @email, HASHBYTES('SHA2_512', @password))

		insert into [dbo].[Customers](AccountID, LastName, FirstName, MiddleName, DateOfBith)
		output inserted.CustomerID into @IDs
		values ((select top 1 ID from @IDs), @lastName, @firstName, @middleName, @dob)
		commit tran
			
		select ID from @IDs
	end
go

--exec [dbo].[AddNewCustomer] 'wda2wd', 'awd2a2wd', 'awda2wd', '1.1.2000', '183744438', '23333433', '22222' 
--go



exec [dbo].[AddNewCustomer] 'Дрягина', 'Вера', 'Семеновна', '20.06.1956 0:00:00', '79597218076', 'vera7606@hotmail.com', 'Rj58K37vo1GLY7sk8x'
exec [dbo].[AddNewCustomer] 'Никишов', 'Иван', 'Юрьевич', '05.04.1984 0:00:00', '79789641998', 'ivan22021996@ya.ru', 'Xw06B19br3FVP7fb0n'
exec [dbo].[AddNewCustomer] 'Каипова', 'Вероника', 'Филипповна', '31.12.1961 0:00:00', '79202423428', 'veronika28111973@mail.ru', 'Fw74N29et3OSI8bf2q'
exec [dbo].[AddNewCustomer] 'Гаврикова', 'Алла', 'Давидович', '13.04.1988 0:00:00', '79575882751', 'alla.gavrikova@gmail.com', 'Mr42A43gr7TRQ9qr7e'
exec [dbo].[AddNewCustomer] 'Теплых', 'Кирилл', 'Александрович', '29.03.1972 0:00:00', '79272433062', 'kirill1984@hotmail.com', 'Ni19F71px0ONY4ia5u'
exec [dbo].[AddNewCustomer] 'Лысов', 'Адам', 'Викторович', '11.02.1982 0:00:00', '79481595325', 'adam1670@gmail.com', 'Sy10G40rx7SCG0vc3j'
exec [dbo].[AddNewCustomer] 'Кияк', 'Алина', 'Игнатьевна', '17.06.1987 0:00:00', '79135826412', 'alina1129@gmail.com', 'En98K21fv2HXC9em4i'
exec [dbo].[AddNewCustomer] 'Исмайлова', 'Сюзанна', 'Феоктистовна', '11.02.1966 0:00:00', '79367467647', 'syuzanna06071994@rambler.ru', 'Wn20F81yh4CIY6vp0u'
exec [dbo].[AddNewCustomer] 'Жутов', 'Петр', 'Егорович', '04.06.1952 0:00:00', '79082985993', 'petr25041984@yandex.ru', 'Uv12E46xp2COI7cn2z'
exec [dbo].[AddNewCustomer] 'Николаенко', 'Антонина', 'Ефремовна', '16.05.1974 0:00:00', '79776612371', 'antonina1982@yandex.ru', 'Rb22V77yi2HHB6lo4s'
exec [dbo].[AddNewCustomer] 'Пайкова', 'Анфиса', 'Игнатьевна', '03.04.1964 0:00:00', '79653957438', 'anfisa1978@yandex.ru', 'Aq59O71xt5WDQ6qc9o'
exec [dbo].[AddNewCustomer] 'Никольникова', 'Марьяна', 'Иннокентьевна', '05.05.1977 0:00:00', '79373141181', 'maryana1985@yandex.ru', 'Hn44H63xa8XFP7yy8c'
exec [dbo].[AddNewCustomer] 'Чеботарёва', 'София', 'Дмитриевна', '04.06.1957 0:00:00', '79128333597', 'sofiya13021995@hotmail.com', 'Ro68Y34cq6LOM0zk7o'
exec [dbo].[AddNewCustomer] 'Бок', 'Прохор', 'Александрович', '03.12.1957 0:00:00', '79745776167', 'prohor1966@outlook.com', 'Hh28E08ig3SSU0vw9q'
exec [dbo].[AddNewCustomer] 'Мухин', 'Тимофей', 'Степанович', '30.10.1985 0:00:00', '79785036869', 'timofey1983@outlook.com', 'Oc85S25il1QJE3rv8l'
exec [dbo].[AddNewCustomer] 'Яровая', 'Надежда', 'Федоровна', '07.12.1988 0:00:00', '79884564175', 'nadejda26@hotmail.com', 'Mu00F79yr5QDA7bz0m'
exec [dbo].[AddNewCustomer] 'Косяк', 'Ефрем', 'Михаилович', '30.10.1987 0:00:00', '79547065870', 'efrem1980@mail.ru', 'No56L16zn3CEZ4fd8m'
exec [dbo].[AddNewCustomer] 'Глушков', 'Савва', 'Павлович', '19.02.1952 0:00:00', '79181011610', 'savva.glushkov@yandex.ru', 'Pu72X77bp6CJQ3dx1x'
exec [dbo].[AddNewCustomer] 'Дворникова', 'Валентина', 'Филипповна', '20.05.1956 0:00:00', '79917215491', 'valentina.dvornikova@rambler.ru', 'Qx58L65jr6UPE5ax9u'
exec [dbo].[AddNewCustomer] 'Лазаренко', 'Данила', 'Георгиевич', '01.10.1964 0:00:00', '79255218729', 'danila8332@hotmail.com', 'Rx60B34ym8VOA2tw1a'
exec [dbo].[AddNewCustomer] 'Зырянов', 'Адам', 'Валерьевич', '03.01.2001 0:00:00', '79394251731', 'adam1975@yandex.ru', 'Ir34D38zx8PLF0xf2z'
exec [dbo].[AddNewCustomer] 'Белибердиев', 'Георгий', 'Прокльев', '09.07.1992 0:00:00', '79856336712', 'georgiy15021963@hotmail.com', 'Nl96B58dt3LRX8zm6i'
exec [dbo].[AddNewCustomer] 'Завразин', 'Александр', 'Леонтьевич', '25.09.1975 0:00:00', '79218522156', 'aleksandr.zavrazin@gmail.com', 'Nt23N08jq4DBO8im5i'
exec [dbo].[AddNewCustomer] 'Емельяненко', 'Валентин', 'Вениаминович', '20.11.2000 0:00:00', '79962264594', 'valentin18051967@gmail.com', 'Hw22B64fs5GPH8sm0h'
exec [dbo].[AddNewCustomer] 'Гречко', 'Михаил', 'Ипполитович', '16.11.1954 0:00:00', '79388872639', 'mihail22051968@ya.ru', 'Lp11F66ix7OLL1qb6f'
exec [dbo].[AddNewCustomer] 'Сухих', 'Леонтий', 'Александрович', '25.06.1950 0:00:00', '79638648830', 'leontiy9332@mail.ru', 'Kr96S39sn8BOU1dp2u'
exec [dbo].[AddNewCustomer] 'Закревская', 'Виктория', 'Ростиславовна', '26.10.1979 0:00:00', '79188811064', 'viktoriya01091970@hotmail.com', 'Xn98C14ab6ALM6tv2b'
exec [dbo].[AddNewCustomer] 'Вотяков', 'Илья', 'Федорович', '28.10.1980 0:00:00', '79881312581', 'ilya91@gmail.com', 'Qi02C11hz1MNI9fn4l'
exec [dbo].[AddNewCustomer] 'Якухина', 'Алла', 'Ростиславовна', '02.03.1992 0:00:00', '79978519554', 'alla1996@mail.ru', 'Wm23W05lp9BIW5qe2x'
exec [dbo].[AddNewCustomer] 'Чупалов', 'Илья', 'Ефимович', '29.07.1961 0:00:00', '79146597064', 'ilya57@yandex.ru', 'Wr99M85dr4GCG4mf1k'
exec [dbo].[AddNewCustomer] 'Рамазанов', 'Арсений', 'Георгиевич', '20.05.1950 0:00:00', '79593839030', 'arseniy21061987@mail.ru', 'Dh57O39vq0RUZ6ho1w'
exec [dbo].[AddNewCustomer] 'Дресвянина', 'Марьяна', 'Тимофеевна', '26.11.1979 0:00:00', '79917122920', 'maryana7334@mail.ru', 'Tm38W93vv9KIN7gu9i'
exec [dbo].[AddNewCustomer] 'Бессмертная', 'Марина', 'Феоктистовна', '08.07.1996 0:00:00', '79396823696', 'marina55@hotmail.com', 'Lo50Y19sh5YWI3nq5u'
exec [dbo].[AddNewCustomer] 'Мещеряков', 'Филипп', 'Дмитриевич', '30.10.1971 0:00:00', '79644207560', 'filipp1981@yandex.ru', 'Sv14D82re9SVI2gl0f'
exec [dbo].[AddNewCustomer] 'Овсова', 'Юлиана', 'Семеновна', '14.07.1972 0:00:00', '79604363814', 'yuliana.ovsova@yandex.ru', 'Js82B38bb9ZDS9np0f'
exec [dbo].[AddNewCustomer] 'Богоносцева', 'Марианна', 'Феликсовна', '15.12.1953 0:00:00', '79175744290', 'marianna1967@ya.ru', 'Ld74V75rq6BWN4cl7w'
exec [dbo].[AddNewCustomer] 'Афонин', 'Антон', 'Валерьевич', '26.11.1979 0:00:00', '79775132647', 'anton86@ya.ru', 'De28E71va8VQE2yu2r'
exec [dbo].[AddNewCustomer] 'Ёлшина', 'Марианна', 'Васильевна', '13.09.1963 0:00:00', '79588471023', 'marianna1990@outlook.com', 'Bn56F40cl7POV7nc9e'
exec [dbo].[AddNewCustomer] 'Лигачёва', 'Оксана', 'Макаровна', '04.01.1965 0:00:00', '79517205234', 'oksana1228@outlook.com', 'Ot68N88zx6PRV7lv0p'
exec [dbo].[AddNewCustomer] 'Шашлова', 'Ася', 'Макаровна', '06.08.1977 0:00:00', '79517212270', 'asya1991@hotmail.com', 'Al15T14hz8RDA6ad5k'
exec [dbo].[AddNewCustomer] 'Званцов', 'Иннокентий', 'Порфирьевич', '02.11.1983 0:00:00', '79486781675', 'innokentiy1989@yandex.ru', 'Zv44C48bu7JXL4jd8j'
exec [dbo].[AddNewCustomer] 'Рубанов', 'Семен', 'Иннокентиевич', '26.12.1957 0:00:00', '79785244623', 'semen1991@outlook.com', 'Xt05V02np0UQY4kp7q'
exec [dbo].[AddNewCustomer] 'Куимова', 'Нина', 'Федоровна', '16.10.1950 0:00:00', '79152616484', 'nina1983@hotmail.com', 'Bd80Q56zf6QMD7jn9x'
exec [dbo].[AddNewCustomer] 'Ерёмин', 'Валентин', 'Георгиевич', '06.11.1964 0:00:00', '79623436587', 'valentin16111989@mail.ru', 'Pi99G09dl5BXQ5vi0a'
exec [dbo].[AddNewCustomer] 'Сивакова', 'Милана', 'Витальевна', '17.10.1984 0:00:00', '79238266428', 'milana2855@ya.ru', 'Lz21Z89oq9OXM7lb6d'
exec [dbo].[AddNewCustomer] 'Чудов', 'Павел', 'Яковлевич', '08.09.1959 0:00:00', '79453646641', 'pavel9816@ya.ru', 'Qb63D41tz9IKI4gl2j'
exec [dbo].[AddNewCustomer] 'Аршавина', 'Анастасия', 'Юрьевна', '16.04.1960 0:00:00', '79477352664', 'anastasiya.arshavina@mail.ru', 'Yb34I28po1FMD1vj5u'
exec [dbo].[AddNewCustomer] 'Кайпанов', 'Федор', 'Ростиславович', '01.05.1981 0:00:00', '79439121250', 'fedor8588@outlook.com', 'Bq81Y53nf4GGD6mf1i'
exec [dbo].[AddNewCustomer] 'Погодин', 'Захар', 'Павлович', '30.04.1983 0:00:00', '79743476758', 'zahar8692@ya.ru', 'Ie28P57ne2NDQ6rh5d'
exec [dbo].[AddNewCustomer] 'Чеботова', 'Нонна', 'Игнатьевна', '07.06.1997 0:00:00', '79912538514', 'nonna.chebotova@hotmail.com', 'Jv97R13xb7QZS0yl4v'
exec [dbo].[AddNewCustomer] 'Аслаханов', 'Вениамин', 'Викторович', '17.05.1990 0:00:00', '79569475070', 'veniamin28081965@gmail.com', 'Fo10E37hq6LKY0fz8i'
exec [dbo].[AddNewCustomer] 'Шувалова', 'Марина', 'Леонтьевна', '07.10.1973 0:00:00', '79995511068', 'marina13@hotmail.com', 'Ps36S75fu0RFG4ux3f'
exec [dbo].[AddNewCustomer] 'Индик', 'Клара', 'Петровна', '11.03.1989 0:00:00', '79429555874', 'klara42@outlook.com', 'Vk98R36js8MBD1zf0x'
exec [dbo].[AddNewCustomer] 'Алешин', 'Максим', 'Артемович', '24.10.1996 0:00:00', '79688921141', 'maksim28@gmail.com', 'Lj60Y29kf9EEW7bn0q'
exec [dbo].[AddNewCustomer] 'Сенькина', 'Нина', 'Венедиктовна', '24.06.1992 0:00:00', '79414398783', 'nina.senkina@gmail.com', 'Qj03V33an0HGR0lt4e'
exec [dbo].[AddNewCustomer] 'Усачёв', 'Михаил', 'Себастьянович', '13.10.1967 0:00:00', '79928661255', 'mihail1452@outlook.com', 'Ar79K45sp3CPY5gh5j'
exec [dbo].[AddNewCustomer] 'Архипов', 'Яков', 'Акимович', '07.02.2001 0:00:00', '79144631630', 'yakov.arhipov@ya.ru', 'Vt61K29rm1LAQ3sq1w'
exec [dbo].[AddNewCustomer] 'Гордеева', 'Анна', 'Николаевна', '09.06.1973 0:00:00', '79791296724', 'anna1979@hotmail.com', 'Sy36S74mj6LTX3kj6k'
exec [dbo].[AddNewCustomer] 'Сафиюлина', 'Анфиса', 'Якововна', '23.10.1974 0:00:00', '79929218095', 'anfisa.safiyulina@outlook.com', 'Jq47A51hl2FZD4cr0n'
exec [dbo].[AddNewCustomer] 'Драке', 'Рада', 'Константиновна', '05.11.1955 0:00:00', '79316264857', 'rada16121981@hotmail.com', 'Xm98O00kn6FZC2rn8f'
exec [dbo].[AddNewCustomer] 'Ефремовича', 'Ксения', 'Якововна', '11.11.1959 0:00:00', '79229839950', 'kseniya14121990@outlook.com', 'Hb54Z21si3VTJ8mm9k'
exec [dbo].[AddNewCustomer] 'Матвиенко', 'Юлиана', 'Феоктистовна', '21.03.1992 0:00:00', '79595255147', 'yuliana9454@mail.ru', 'Xs91R62id7LXG4wf0k'
exec [dbo].[AddNewCustomer] 'Тевосова', 'Марина', 'Якововна', '25.06.1954 0:00:00', '79817262285', 'marina7413@hotmail.com', 'Zp43T07xw1PSR1ah4i'
exec [dbo].[AddNewCustomer] 'Кабицин', 'Юлиан', 'Михаилович', '24.02.1996 0:00:00', '79889302376', 'yulian1964@yandex.ru', 'Ws78Z98lo2NQL0xk2l'
exec [dbo].[AddNewCustomer] 'Яглинцев', 'Александр', 'Александрович', '20.05.1970 0:00:00', '79948461336', 'aleksandr2381@outlook.com', 'Fc97J15at7GDK9en3g'
exec [dbo].[AddNewCustomer] 'Чиркаш', 'Александр', 'Евгеньевич', '15.09.1986 0:00:00', '79412143330', 'aleksandr8919@gmail.com', 'Mk86D63me6USV8bc7x'
exec [dbo].[AddNewCustomer] 'Панкова', 'Ольга', 'Феликсовна', '07.07.1998 0:00:00', '79537746784', 'olga35@rambler.ru', 'Js49C63dd7GOO1nz0i'
exec [dbo].[AddNewCustomer] 'Немов', 'Иван', 'Власович', '14.06.1976 0:00:00', '79497568819', 'ivan1457@outlook.com', 'Ve07J49cl2IUK6lx0a'
exec [dbo].[AddNewCustomer] 'Магазинер', 'Макар', 'Макарович', '15.03.1975 0:00:00', '79365741389', 'makar.magaziner@hotmail.com', 'Uy74F78bg5HWB7gc7i'
exec [dbo].[AddNewCustomer] 'Ерхова', 'Ася', 'Давидовна', '30.10.2001 0:00:00', '79126296083', 'asya1970@rambler.ru', 'Bn15X88yw9CHN9no5a'
exec [dbo].[AddNewCustomer] 'Куимова', 'Аполлинария', 'Ростиславовна', '02.09.1986 0:00:00', '79083499364', 'apollinariya1980@ya.ru', 'Vy43T51kg0DNR5az9r'
exec [dbo].[AddNewCustomer] 'Дутова', 'Мила', 'Алексеевна', '05.10.1967 0:00:00', '79705617439', 'mila1989@yandex.ru', 'Xq38A11gu9OFR0bm0o'
exec [dbo].[AddNewCustomer] 'Рудавина', 'Милана', 'Михаиловна', '14.12.1958 0:00:00', '79237264162', 'milana.rudavina@rambler.ru', 'Ja74O87kl6MZN8gd0l'
exec [dbo].[AddNewCustomer] 'Иванов', 'Кирилл', 'Львович', '10.05.1955 0:00:00', '79465291511', 'kirill23021981@hotmail.com', 'Mf63I46wl4QCY4vh3c'
exec [dbo].[AddNewCustomer] 'Афанасьева', 'Зоя', 'Антоновна', '13.10.1961 0:00:00', '79649268568', 'zoya95@yandex.ru', 'Vz27S53za3LYZ0yc9t'
exec [dbo].[AddNewCustomer] 'Коллеров', 'Константин', 'Захарович', '18.02.1988 0:00:00', '79617405976', 'konstantin.kollerov@ya.ru', 'My80H97po5SPY0vp1e'
exec [dbo].[AddNewCustomer] 'Смешной', 'Леонтий', 'Иванович', '11.07.1974 0:00:00', '79238267432', 'leontiy10071992@rambler.ru', 'Xt05R59nq0AHV5oq2y'
exec [dbo].[AddNewCustomer] 'Верица', 'Вероника', 'Прохоровна', '17.03.1999 0:00:00', '79264287062', 'veronika28061988@mail.ru', 'Zt99U42sn9DLV9nw9l'
exec [dbo].[AddNewCustomer] 'Лукашевич', 'Екатерина', 'Денисовна', '06.02.1972 0:00:00', '79145511648', 'ekaterina.lukashevich@mail.ru', 'Gm34D55gx0JKO6ef7a'
exec [dbo].[AddNewCustomer] 'Ромазанов', 'Виктор', 'Севастьянович', '13.03.1990 0:00:00', '79824405925', 'viktor21061964@hotmail.com', 'Gc38M55qe3IRP1ws4q'
exec [dbo].[AddNewCustomer] 'Беляков', 'Игнат', 'Петрович', '17.10.1965 0:00:00', '79986515222', 'ignat.belyakov@mail.ru', 'Tl21K61np7QRU8ff3w'
exec [dbo].[AddNewCustomer] 'Ковалёва', 'Лана', 'Валентиновна', '20.01.1982 0:00:00', '79216247255', 'lana83@hotmail.com', 'Ww69J85ku2RZS5kg3a'
exec [dbo].[AddNewCustomer] 'Перевалов', 'Кирилл', 'Венедиктович', '31.08.1999 0:00:00', '79546584524', 'kirill1995@ya.ru', 'Yf20X85sn8JZO8wu4c'
exec [dbo].[AddNewCustomer] 'Закрятина', 'Анжела', 'Феодосьевна', '03.03.1977 0:00:00', '79319297346', 'anjela14041980@mail.ru', 'Xh82K39ux1KPW2jx4o'
exec [dbo].[AddNewCustomer] 'Дагина', 'Ася', 'Трофимовна', '21.04.1992 0:00:00', '79257252021', 'asya5939@rambler.ru', 'Tb71A54gd1VUZ1vd6d'
exec [dbo].[AddNewCustomer] 'Шведова', 'Любовь', 'Романовна', '17.08.2000 0:00:00', '79533346644', 'lyubov.vedova@yandex.ru', 'Xt90R51fm7EXL2qj4c'
exec [dbo].[AddNewCustomer] 'Малышева', 'Вероника', 'Евгеньевна', '10.02.1955 0:00:00', '79522904515', 'veronika1978@mail.ru', 'Vr90U60ik4BCR8lr0t'
exec [dbo].[AddNewCustomer] 'Грушецкий', 'Федор', 'Никитьевич', '18.12.2000 0:00:00', '79479292511', 'fedor06051972@outlook.com', 'Dp83Y49gk5JTJ0pi3x'
exec [dbo].[AddNewCustomer] 'Кондратенко', 'Никифор', 'Серафимович', '09.12.1984 0:00:00', '79592569963', 'nikifor.kondratenko@rambler.ru', 'El52S74rm1AOO6mz5x'
exec [dbo].[AddNewCustomer] 'Ванзин', 'Егор', 'Тимофеевич', '29.09.1964 0:00:00', '79662035221', 'egor.vanzin@gmail.com', 'Bp83R70ss0CMC7kp5o'
exec [dbo].[AddNewCustomer] 'Кондрашов', 'Николай', 'Трофимович', '18.05.1967 0:00:00', '79965446079', 'nikolay.kondrashov@yandex.ru', 'Eq58M13zv1WBB3aw0j'
exec [dbo].[AddNewCustomer] 'Комракова', 'Раиса', 'Порфнрьевна', '07.02.1952 0:00:00', '79084337045', 'raisa.komrakova@mail.ru', 'Xm60S53qx8DAY4et6o'
exec [dbo].[AddNewCustomer] 'Авдеев', 'Савва', 'Германович', '26.11.1988 0:00:00', '79996293482', 'savva03061961@ya.ru', 'Jg37G58aa1CWH2nq8m'
exec [dbo].[AddNewCustomer] 'Зырянова', 'София', 'Данииловна', '24.04.1982 0:00:00', '79292761095', 'sofiya30@yandex.ru', 'Vg05L16dx6XQK3jz7p'
exec [dbo].[AddNewCustomer] 'Забирова', 'Анфиса', 'Ефимовна', '25.09.1986 0:00:00', '79319367943', 'anfisa1960@yandex.ru', 'Ll85J58zv8LUI2as5h'
exec [dbo].[AddNewCustomer] 'Беспалова', 'Анастасия', 'Витальевна', '22.05.1989 0:00:00', '79292641865', 'anastasiya26@rambler.ru', 'Wq54Y41mr5YFS0db1z'
exec [dbo].[AddNewCustomer] 'Янко', 'Валерия', 'Акимовна', '04.08.1984 0:00:00', '79492213189', 'valeriya43@mail.ru', 'Sz61V34vo3JPV7as0v'
exec [dbo].[AddNewCustomer] 'Шуста', 'Варвара', 'Федотовна', '23.10.2001 0:00:00', '79096846667', 'varvara1991@hotmail.com', 'Xe20D48ps7EFW7wo7h'
exec [dbo].[AddNewCustomer] 'Гусельникова', 'Валерия', 'Никифоровна', '02.05.1973 0:00:00', '79599446480', 'valeriya1963@yandex.ru', 'Td45O13yd5SIB2ec5m'
exec [dbo].[AddNewCustomer] 'Лютенкова', 'Дарья', 'Нифонтовна', '20.05.1999 0:00:00', '79355306343', 'darya1964@gmail.com', 'Lt97T03en8ZEG4qb8k'
go



create procedure [dbo].[CheckPhoneAndEmail] (@phone numeric(38), 
											 @email varchar(800))
as
	declare @boolean table(bool bit)
	declare @check bit
	
	set @check = case when exists (select PhoneNumber, Email from Accounts where PhoneNumber = @phone or Email = @email) then 1 else 0 end
	
	if (@check = 1)
		insert @boolean values ('1')
	else
		insert @boolean values ('0')

	select* from @boolean
go

--exec [dbo].[CheckPhoneAndEmail] '88005553535', 'b3ashkir@mail.ru' 
--go





create table [dbo].[DocumentTypes] (
	[DocumentTypeID] integer identity primary key,
	[DocumentTypeName] varchar(800) unique not null,
	[Comment] varchar(max) null,
)
go

insert into [dbo].[DocumentTypes] ([DocumentTypeName])
values
('Доверенности'),
('Согласия'),
('Заявления'),
('Завещания'),
('Для юридических лиц'),
('Недвижимости'),
('Доли ООО'),
('Займы'),
('Брачные'),
('Соглашения'),
('Интернет-страницы'),
('Электронная переписка'),
('SMS-сообщения')
go

create table [dbo].[Documents] (
	[DocumentID] integer identity primary key,
	[DocumentTypeID] integer foreign key references [dbo].[DocumentTypes]([DocumentTypeID]) on delete cascade on update cascade not null,
	[DocumentName] varchar(800) unique not null,
	[Tariff] decimal(19,2) check ([Tariff] >= 0) null,
	[Percent] decimal(19,2) check ([Percent] >= 0) null,
	[PerPrice] decimal(19,2) check ([PerPrice] >= 0) null,
	[Docs] varchar(max) not null, 
	[Comment] varchar(max) null,
)
go



















