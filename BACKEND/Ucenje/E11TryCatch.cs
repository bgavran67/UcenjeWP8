using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E11TryCatch
    {
        public static void Izvedi()
        {
            Console.WriteLine("Try Catch");

            //Console.Write("Unesi broj: ");

            int b = 0;

            /*
            //try blok se uvijek izvodi
            try
            {
               b = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Niste unijeli broj.");
            }


            Console.WriteLine(b+1);
            */

            while (true)
            {
                try
                {
                    Console.Write("Unesi broj: ");
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {

                    Console.WriteLine("Niste unijeli broj.");
                }
            }
            Console.WriteLine(b + 1);


            //napisati program koji za dva unesena cijela broja ispisuje njihov zbroj

            int prvib, drugib;
            while (true)
            {

                Console.Write("Unesi prvi broj: ");
                try
                {
                    prvib = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli prvi broj.");
                }

            }



            while (true)
            {

                Console.Write("Unesi drugi broj: ");
                try
                {

                    drugib = int.Parse(Console.ReadLine()); //break ide nakon metode koja uspjesno prode
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli drugi broj.");

                }
            }

            Console.WriteLine("Rezultat {0} + {1} = {2} ", prvib, drugib, prvib + drugib);

            // dobro osiguranje unosa broja
            string unosniNizZnakova;
            while (true)
            {
                Console.Write("Unesi broj: ");
                unosniNizZnakova = Console.ReadLine().Trim();
                if (unosniNizZnakova.Length > 9)
                {
                    Console.WriteLine("Unijeli ste predugacak niz znakova.");
                    continue;
                }
                //sigurna sam da unosi niz znakova nema razmake prije ili poslije i nije duzi od 9 znakova

                try
                {
                    b = int.Parse(unosniNizZnakova);
                    if (b > 10000)
                    {
                        Console.WriteLine("Uneseni broj je prevelik, unesite manji broj.");
                        continue;
                    }
                    break;
                }
                catch 
                {
                    Console.WriteLine("Niste unijeli broj!");
                }
            }
            Console.WriteLine("Unesen je broj {0}.", b);

            // nije dana puna sintaksa ty catch, ostalo nakon OOP-a (objektivno- orijentirano programiranje)














        }
    }
}
