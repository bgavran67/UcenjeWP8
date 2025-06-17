using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt
{
    //klasa je opisnik objekta -> nauciti napamet
    public class Osoba
    {
        // klasa se sastoji od svojstava
        // princip ucahurivanja (OOP Princip)
        // nazivi sredstava se pisu velikim pocetnim slovom

        public int Sifra { get; set; } //ne stavljamo ? jer ima vrijednost 0
        public string? Ime { get; set; } // ? znaci da svojstvo moze biti null

        public string Prezime { get; set; } = ""; // = "" ce postaviti prazno, nece biti null

        public DateTime? DatumRodenja { get; set; }


        //prvi tekst Mjesto je KLASA a drugi tekst Mjesto je SVOJSTVO
        //ovo je veza 1:N u bazi
        public Mjesto? Mjesto { get; set; }

        //ovo je veza N:N u bazi
        //koristimo nizove [] za vise
        public Mjesto[]? Mjesta { get; set; }

        // klasa se sastoji od metodaa
        //ova metoda nije static

        public void IspisiImeIPrezime()
        {
            //kljucna rijec this se odnosi na klasu u kojoj se nalazim
            Console.WriteLine(this.Ime + " " + Prezime);
        }

        //staticne metode se pozivaju na klasi a ne staticne na objektu
        public static void Primjer()
        {
            Console.WriteLine("Primjer staticne metode");
        }





    }
}
