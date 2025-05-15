use master;
go
drop database if exists taksisluzba;
go
create database taksisluzba;
go
use taksisluzba;

create table taksitvrtke(
sifra int not null primary key identity(1,1),
ime varchar (100) not null,
lokacija varchar (150)
);
 
 create table vozaci(
 sifra int not null primary key identity (1,1),
 ime varchar(50) not null,
 prezime varchar(60) not null
 );

create table putnici(
sifra int not null primary key identity(1,1),
ime varchar (50) not null,
prezime varchar (50) not null,
brojtelefona varchar(15) not null,
adresa varchar(100) not null
);

create table vozila(
sifra int not null primary key identity(1,1),
model varchar (50) not null,
tipvozila varchar (50) not null, 
vozac int not null,
taksitvrtka int not null references taksitvrtke(sifra)
);

create table voznje(
sifra int not null primary key identity(1,1),
pocetakvoznje datetime not null,
zavrsetakvoznje datetime not null,
vozac int not null references vozaci(sifra),
putnik int not null references putnici(sifra)
);