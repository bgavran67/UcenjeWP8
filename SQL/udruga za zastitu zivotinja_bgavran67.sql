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

select * from osobe;
insert into osobe (ime, prezime)
values ('Ivana', 'Radić'),
('Luka', 'Vuković'),
('Sara', 'Tomić'),
('Petar', 'Blažević'),
('Nina', 'Marić')

select * from prostori;
insert into prostori (naziv)
values 
('Pasji kutak sreće'),
('Mačji raj'),
('Zeko-zona'),
('Papagajski paviljon'),
('Hrčkova kućica')

insert into sticenici (vrsta, naziv, osobe, prostori)
values 
('Pas', 'Reks', 1, 1),
('Mačka', 'Mica', 2, 2),
('Zec', 'Skoki', 3, 3),
('Papagaj', 'Čiki', 4, 4),
('Hrčak', 'Fifi', 5, 5);