create table Wpisy 
(
	Id int not null primary key,
	Nazwa nvarchar(200) null
)

insert into Wpisy (Id, Nazwa) values (1, 'test')