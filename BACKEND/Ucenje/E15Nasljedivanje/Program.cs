using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E15Nasljedivanje
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("Nasljedivanje");

            var oso = new PontecijalniPolaznik() { Ime = "Marija", Prezime = "Jot" };

            Predavac pre = new() { Ime = "Karlo", Prezime = "Lot", IBAN = "HR82974012990" };

            Polaznik pol = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "099 / 325-666" };

            Polaznik poll = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "099 / 325-666" };

            //sto ce se ispisati?
            Console.WriteLine(pol.Equals(poll)); //False

            Console.WriteLine(pol.GetHashCode()); //43942917
            Console.WriteLine(poll.GetHashCode()); //59941933

            Console.WriteLine(poll.ToString()); //Ucenje.E15Nasljedivanje.Polaznik

            // 2. prolaz, nakon pisanja prepisani meotda
            Console.WriteLine(poll); //ovo je jednako kao da sam pozvao poll.ToString(), Karla Sep 099 / 325-666

            Console.WriteLine(pre);


            string grad = "Osijek";

            Console.WriteLine(grad.GetHashCode()); //641199584

            grad += " je najbolji";

            Console.WriteLine(grad.GetHashCode()); //-1804026246

            //ista varijabla nakon promjene nema isti hashcode - immutable
            //string je immutable klasa (ne moze se mijenjati)
            // svaka promjena string varijable radi novu istancu string klase - NIJE DOBRO!
            //Rjesenje: koristiti StringBuilder klasu

            var sb = new StringBuilder();

            sb.Append("Osijek");
            Console.WriteLine(sb.GetHashCode());

            sb.Append(" je najbolji.");
            Console.WriteLine(sb.GetHashCode()); // --> ima isti broj 2606490



        }
    }
}
