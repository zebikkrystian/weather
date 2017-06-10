create table dbo.Pogoda 
(
	Id int not null primary key,
	Miasto nvarchar(100) not null,
	Kraj nvarchar(100) not null,
	Wojewodztwo nvarchar(100) not null,
	Temperatura nvarchar(100) not null,
	Foto int not null,
	Opis nvarchar(100) not null,
	Opady nvarchar(100) not null,
	Cisnienie nvarchar(100) not null,
	Wiatr nvarchar(100) not null
)

create table dbo.PogodaDni 
(
	Id int not null primary key,
	IdPogoda int not null,
	Dzien nvarchar(100) not null,
	Opis nvarchar(100) not null,
	Temperatura nvarchar(100) not null,
	Foto int not null,
	Cisnienie nvarchar(100) not null
)

insert into dbo.Pogoda(Id, Miasto, Kraj, Wojewodztwo, Temperatura, Foto, Opis, Opady, Cisnienie, Wiatr)
values
(1,'Częstochowa','Polska','śląskie','30 °C',1,'Słonecznie, bez opadów','0 mm/m2','1010 hPa','5 m/s N'),
(2,'Warszawa','Polska','mazowieckie','21 °C',4,'Burze i silne opady deszczu','30 mm/m2','1025 hPa','7,8 m/s N'),
(3,'Gdańsk','Polska','pomorskie','24 °C',1,'Lekkie opady deszczu','10 mm/m2','1030 hPa','4 m/s N')


insert into dbo.PogodaDni(Id, IdPogoda, Dzien, Foto,Opis,Temperatura,Cisnienie)
values
(1,1,'poniedziałek',3, 'Lekkie opady deszczu', '28 °C', '1034 hPa'),
(2,1,'wtorek',2, 'Lekkie zachmurzenie', '24 °C', '1005 hPa'),
(3,1,'środa',4, 'Burze i silny deszcz', '20 °C', '1001 hPa'),

(4,2,'poniedziałek',1, 'Słonecznie', '28 °C', '1034 hPa'),
(5,2,'wtorek',2, 'Lekkie opady', '30 °C', '1045 hPa'),
(6,2,'środa',4, 'Burza i deszcz', '15 °C', '1031 hPa'),

(7,3,'poniedziałek',3, 'Deszczowo i zimno', '28 °C', '1034 hPa'),
(8,3,'wtorek',1, 'Słonecznie', '16 °C', '1025 hPa'),
(9,3,'środa',4, 'Upał', '48 °C', '1050 hPa')