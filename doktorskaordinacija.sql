use master;
go
drop database doktorskaordinacija;
go
create database doktorskaordinacija;
go
use doktorskaordinacija;
go

--create table pacijenti(
--sifra int not null primary key identity(1,1),
--ime varchar (50) not null,
--prezime varchar (60) not null,
--brojtelefona varchar (20) not null,
--email varchar (100)
--);

--create table doktori(
--sifra int not null primary key identity(1,1),
--ime varchar (50) not null,
--prezime varchar (50) not null,
--email varchar (100)
--);

--create table medicinskesestre(
--sifra int not null primary key identity(1,1),
--ime varchar (50) not null,
--prezime varchar (60) not null
--);

--create table posjeti(
--sifra int not null primary key identity(1,1),
--pacijenti int not null references pacijenti(sifra),
--doktori int not null references doktori(sifra),
--datumvrijeme datetime not null
--);


--create table lijecenja(
--sifra int not null primary key identity(1,1),
--naziv varchar (100) not null,
--pacijenti int references pacijenti(sifra)
--);

--create table medicinskesestrepomoc(
--sifra int not null primary key identity(1,1),
--posjeti int not null references posjeti(sifra),
--medicinskesestre int not null references medicinskesestre(sifra)
--);

