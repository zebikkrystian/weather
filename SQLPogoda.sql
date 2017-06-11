create table dbo.Pogoda 
(
	Id int not null primary key,
	Miasto nvarchar(100) not null,
	Kraj nvarchar(100) not null,
	Wojewodztwo nvarchar(100) not null,
	Temperatura int not null,
	Foto int not null,
	Opis nvarchar(100) not null,
	Opady int not null,
	Cisnienie int not null,
	Wiatr int not null
)

create table dbo.PogodaDni 
(
	Id int not null primary key,
	IdPogoda int not null,
	Dzien nvarchar(100) not null,
	Opis nvarchar(100) not null,
	Temperatura int not null,
	Foto int not null,
	Cisnienie int not null
)

insert into dbo.Pogoda(Id, Miasto, Kraj, Wojewodztwo, Temperatura, Foto, Opis, Opady, Cisnienie, Wiatr)
values
(1,'Częstochowa','Polska','śląskie',30,1,'Słonecznie, bez opadów',0,1010,5),
(2,'Warszawa','Polska','mazowieckie',21,4,'Burze i silne opady deszczu',30,1025,7),
(3,'Gdańsk','Polska','pomorskie',24,1,'Lekkie opady deszczu',10,1030,4)


insert into dbo.PogodaDni(Id, IdPogoda, Dzien, Foto,Opis,Temperatura,Cisnienie)
values
(1,1,'poniedziałek',3, 'Lekkie opady deszczu', 28, 1034),
(2,1,'wtorek',2, 'Lekkie zachmurzenie', 24, 1005),
(3,1,'środa',4, 'Burze i silny deszcz', 20, 1001),

(4,2,'poniedziałek',1, 'Słonecznie', 28, 1034),
(5,2,'wtorek',2, 'Lekkie opady', 30, 1045),
(6,2,'środa',4, 'Burza i deszcz', 15, 1031),

(7,3,'poniedziałek',3, 'Deszczowo i zimno', 28, 1034),
(8,3,'wtorek',1, 'Słonecznie', 16, 1025),
(9,3,'środa',4, 'Upał', 48, 1050)