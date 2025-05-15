use master;
go
drop database if exists fakultet;
go
create database fakultet;
go
use fakultet;

create table kolegiji(
sifra int not null primary key identity(1,1),
predmet varchar (100) not null
);

create table prijave(
sifra int not null primary key identity(1,1),
studenti int not null,
rokovi int not null,
nazivpredmeta varchar (100) not null,
vrijemedatum datetime not null
);

create table rokovi(
sifra int not null primary key identity(1,1),
vrijemedatum datetime not null,
kolegiji int not null references kolegiji(sifra)
);

create table studenti(
sifra int not null primary key identity(1,1),
ime varchar (50) not null,
prezime varchar (50) not null,
prijave int not null references prijave(sifra),
rokovi int not null references rokovi(sifra)
);

