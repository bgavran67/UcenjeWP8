using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E12Metode
    {
        //metoda - organizacijska jedinica koda koja sluzi odredenjoj svrsi
        //cilj - write once, use everywhere
        // static - metoda se moze izvesti na klasi
        public static void Izvedi()
        {
            Console.WriteLine("Metode");
            
            //poziv metode
            Tip1();
            for (int i = 0; i < 10; i++)
            {
                Tip1();
            }

            Tip2(2);

            Tip2(7);

            Tip2(2, 3); // po  zavrsetku metode nema povratnu vrijednost

            Tip3(); //po zavrsetku metode vracena vrijednost nikome nije dodjeljena

            string s = Tip3();
            Console.WriteLine(s);

            Console.WriteLine(prim(5));
            Console.WriteLine(prim(100000));

            for(int i = 1;i <= 100; i++)
            {
                if (prim(i))
                {
                    Console.WriteLine(i);
                }
            }

            //napisi program koji zbraja dva broja
            Console.WriteLine(ucitajCijeliBroj("Unesi 1. broj")+ ucitajCijeliBroj("Unesi 2. broj"));


        } //kraj metode

        // metoda TIPA 1
        // ne prima parametar i ne vraca vrijednost
        //tijelo metode
        static void Tip1()
        {
            Console.WriteLine("Ispis iz metode tipa 1 koja je bez nacina pristupa - vidljiva samo u klasi");
            Console.WriteLine("********");
            Console.WriteLine("Edunova");
            Console.WriteLine("********");
        }


        // metoda TIPA 2
        // Prima parametre i ne vraca vrijednost

        private static void Tip2(int i)
        {
            Console.WriteLine("Primio sam broj {0}", i);
        }

        // potpis metode 
        // nacin pristupa
        // static ili ne (prazno)
        // tip podatka (void ili neki tip)
        // -> naziv 
        // -> lista parametra

        //method overloading - preopterecenje metode
        private static void Tip2(int i, int j)
        {
            Console.WriteLine("Zbroj je {0}", i + j);
        }

        //metoda TIPA 3
        //ne prima parametre, vraca vrijednost
        protected static string Tip3()
        {
            Console.WriteLine("Izvodim metodu Tip3");
            return "Web programiranje";
        }

        //metoda TIPA 4
        //Prima parametre, vraca vrijednost
        //da li je primljeni broj prim/prome/prosti ili ne
        public static bool prim(int broj)
        {
            //matematicki princip hipoteze (predpostavka)
            for(int i = 2; i < broj; i++)
            {
                // za 5
                if(broj % i == 0)
                {
                    return false; 
                    //prekidanjem metode prekida se i petlja
                }
            }

            return true;
        }

        public static int ucitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Pokusaj ponovno.");
                }
            }








        }

    } //kraj klase
}
