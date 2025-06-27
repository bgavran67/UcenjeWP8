using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18GSALE
{
    public class Program
    {
        public Program()
        {
            //generici se koriste u LISTAMA

            Console.WriteLine("GSALE");
            var o = new Obrada<string>(); //parametizira sa stringom, obraduje SAMO string
            o.PredmetObrade = "Osijek";
            //o.PredmetObrade = 67; greska jer predmet obrade moze biti samo string(<string>)

            o.Posao();


            var obrada = new Obrada<int>();
            obrada.PredmetObrade = 67; //sada prolazi jer smo mu dali INT
           // obrada.PredmetObrade = "Osijek" sada ne moze jer se trazi INT 

            obrada.Posao();

            //rad s listama
            //List lista = new List(); --> ovako ne mozemo

            var lista = new List<string>(); //lista iskljucivo stringova, ne moramo napisati koliko ima
            //string[] gradovi = new string[10] --> kao ovdje, tu trebamo znati (nizovi)

            lista.Add("Osijek");
            lista.Add("Zagreb");
            Console.WriteLine(lista[0]); //ispisuje se Osijek --> koristimo ih ISTO kao nizove
            Console.WriteLine("*****************************");
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }

            var brojevi = new List<int>() {2,3,34,5,3,5};
            brojevi.Add(3); //dodajemo jos jedan broj "3" u niz
           
            foreach(int i in brojevi)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(brojevi.Count);

            brojevi.RemoveAt(1); //obrisi broj na indexu [1]
            Console.WriteLine(brojevi.Count);
            Console.WriteLine(brojevi); //System.Collections.Generic.List`1[System.Int32]

            Console.WriteLine("**************************");
            //var eo = new EdunovaObrada<string>(); --> greska jer string ne nasljeduje entitet
            var os = new Obrada<Smjer>(); //smjer nasljeduje object
            var eo = new EdunovaObrada<Smjer>();

            eo.Entitet = new Smjer() { Sifra = 1, Naziv = "WP" };
            eo.OdradiPosao(); //ispisuje 1

            var op = new EdunovaObrada<Polaznik>();
            op.Entitet = new Polaznik() { Sifra = 10, Ime = "Pero" };
            op.OdradiPosao(); //ispisuje 10

            var lo = new Obrada<List<Smjer>>(); //obrada je parametrizana sa listom smjerova

            //ATRIBUTI
            var smjerovi = new List<Smjer>();

            //unutra mogu ici samo smjerovi

            smjerovi.Add(new Smjer() { Naziv = "Web programiranje" });

            smjerovi.Add(new Smjer() { Naziv = "Racunovodstvo" });

            smjerovi.Sort(); //metoda Sort zove metodu CompareTo

            foreach(var s in smjerovi)
            {
                Console.WriteLine(s); //ispisuje Racunovodstvo i Web Programiranje jer smo dodali ToString u SMJERU!
            }
            Console.WriteLine("************************");
            //6. nacin iteracije: MEOTDA ForEach - funkcionalno programiranej
            smjerovi.ForEach(s => Console.WriteLine(s)); //=> Lambda izraz

            Console.WriteLine(Zbroji(2,3)); //pozivamo je

            //kreiranje interne metode s pomocu lambda izraza
            //nalazimo se unutar konstruktora
            var Zbroj = (int i, int j) => i + j; //nije objektno

            Console.WriteLine(Zbroj(2,3));

            var algoritam = (int x, int y) =>
            {
                var k = 2;
                k += x;
                y = --y + k;
                return k + x + y;
            };
            Console.WriteLine(algoritam(1,2));

            //nastavak gore smjerovi.Sort();

           
            smjerovi.Sort(( s1,  s2) =>
            {
                return s1.CompareTo(s2); 
            });

            smjerovi[0].Naziv.EdunovaProvjera();
            o.PredmetObrade.EdunovaProvjera();

            int r = smjerovi[0].Broj();
            r = eo.Broj();

            Console.WriteLine("{0},{1}",r, eo.Broj());
            



        } //kraj konstruktora

        private int Zbroji(int i, int j) //pozvana je gore
        {
            return i + j; //ispisuje 5, 2+3=5
        }



    }
}
