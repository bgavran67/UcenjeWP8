using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt
{
    class Program
    {

        //5. vrsta metode je konstruktor
        // naziv mora biti jedan nazivu klase

        public Program()
        {
            Console.WriteLine("Klasa/objekt");

            //objekt je pojavnost (instanca) klase - nauciti napamet

            // Oosoba (primjetiti veliko slovo O) je KLASA
            // osoba (malo slovo O) je OBJEKT -> naziva se instanca/varijabla

            Osoba osoba = new Osoba(); //pozvali smo konstruktor od klase Osoba (new)

            //postavljanje vrijednosti za svojstva objekta
            osoba.Sifra = 1; //pozvao si setter (ucahurivanje)
            //osoba.Ime = "Pero"; - namjerno ga ostavljamo null jer ono moze biti null (? smo stavili)
            osoba.Prezime = "Peric";
            osoba.DatumRodenja = new DateTime(1980, 12, 7);

            // ponoviti cu s uzimanjem vrijednosti od nasih korisnika
            //osoba.Sifra = Pomocno.ucitajCijeliBroj("Unesi sifru osobe"); //usporediti s linijom 20
            //osoba.Prezime = Pomocno.UcitajString("Unesi prezime osobe");
            //osoba.DatumRodenja = new DateTime(
            //    Pomocno.ucitajCijeliBroj("Unesi godinu rodenja"),
            //    Pomocno.ucitajCijeliBroj("Unesi mjesec rodenja"),
            //    Pomocno.ucitajCijeliBroj("Unesi dan rodenja")
            //    );

            //koristenje vrijednosti svojstava
            Console.WriteLine(osoba.Prezime); //pozvao si getter (ucahurivanje)

            Console.WriteLine(osoba.Ime); //ispise prazno
            Console.WriteLine(osoba.Ime??"nije postavljeno"); //ime moze biti null, ?? znaci sto ce biti ako je null
                                                              //ako je ime null ispisi prazno
                                                              //iapise nije postavljeno
            //ne staticna metoda se zove s objekta
            osoba.IspisiImeIPrezime();

            //osoba.Primjer(); -> ne moze se pozvati staticnu metodu s objekta

            Osoba.Primjer(); //-> staticnu metodu pozivamo S KLASE

            //Osoba.IspisiImeIPrezime(); na klasi se ne moze pozvati ne staticna metoda


            Osoba[] osobe = new Osoba[3];

            //skraceni oblik postavljanja vrijednosti svojstava
            osobe[0] = new Osoba()
            {
                Ime = "Marija",
                Prezime = "Kat",
                Sifra = 2,
                DatumRodenja = new DateTime(1980, 1, 2)
            };

            osobe[1] = new() { Ime = "Ante" }; 
            osobe[2] = osoba;
            foreach(Osoba o in osobe){
                Console.WriteLine(o.Ime);
            } //prikazuje samo Mariju i Ante


            //ovdje je Mjesto na osobi null (?)
            Console.WriteLine(osoba.Mjesto?.Naziv ?? "Nije postavljeno");

            //ovdje na osoba dodjeljujem Mjesto na novu instancu klase mjesto s vrijednoscu naziva Osijek
            osoba.Mjesto = new() { Naziv = "Osijek", Zupanija = new Zupanija() { Naziv = "OBZ", Zupan = new() { Ime = "Natasa" } } };

            //ovdje Mjesto nije null i  naziv je postavljen
            Console.WriteLine(osoba.Mjesto?.Naziv ?? "Nije postavljeno");

            osoba.Ime = "Pero";

            //osoba.Mjesto.Zupanija = new Zupanija() { Naziv ="OBZ", Zupan = new() { Ime= "Natasa"} };


            //Koji je smisao OOP-a
            //Console.WriteLine(osoba.Mjesto?.Zupanija.Zupan.Ime);


            //ispisati Perso s objekta osoba
            Console.WriteLine(osoba.Ime);

            //ispisati obz
            Console.WriteLine(osoba.Mjesto?.Zupanija.Naziv);

            //ispisati Osijek
            Console.WriteLine(osoba.Mjesto?.Naziv);
        }

        //Zadatak: kreirati klasu automobil s 5 svojstava
        public static void AutomobilZadatak()
        {
            Automobil automobil = new Automobil();
            automobil.Sifra = 1;
            automobil.Marka = "Mercedes";
            automobil.Automatik = false;
            automobil.DatumProizvodnje = new DateTime(1991, 11, 1);
            automobil.Cijena = 14525.20M;

            Console.WriteLine(automobil.DatumProizvodnje);

        }




    }



    
}
