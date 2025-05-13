use master;
go
drop database if exists djecjivrtic;
go
create database djecjivrtic;
go
use djecjivrtic;

create table odgajateljice(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
);

create table odgojneskupine (
sifra int not null primary key identity(1,1),
naziv varchar(60) not null,
odgajateljica int references odgajateljice(sifra)
);

create table djeca(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
odgojneskupine int references odgojneskupine(sifra)
);

create table strucnespreme(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
odgajateljica int references odgajateljice(sifra)
);

