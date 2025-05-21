use master;
go
drop database if exists udrugazazastituzivotinja;
go
create database udrugazazastituzivotinja collate Croatian_CI_AS;
go
use udrugazazastituzivotinja;
go
create table osobe(
sifra int primary key identity(1,1),
ime varchar (50) not null,
prezime varchar (50) not null
);

create table prostori(
sifra int primary key identity(1,1),
lokacija decimal(11,8) null,
naziv varchar(50) not null
);

create table sticenici(
sifra int primary key identity(1,1),
vrsta varchar (50) not null,
naziv varchar (60) not null,
osobe int references osobe(sifra),
prostori int references prostori(sifra)
);

insert into osobe (ime, prezime)
values ('Ivana', 'Radić'),
('Luka', 'Vuković'),
('Sara', 'Tomić'),
('Petar', 'Blažević'),
('Nina', 'Marić')

insert into prostori (naziv)
values ('Pasji kutak sreće'),
('Mačji raj'),
('Zeko-zona'),
('Papagajski paviljon'),
('Hrčkova kućica ')