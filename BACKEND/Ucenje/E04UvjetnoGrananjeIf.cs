using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E04UvjetnoGrananjeIf
    {
        public static void Izvedi()
        {

            Console.WriteLine("E04UvjetnoGrananjeIf");

            int broj = 7; //ovo je unio korisnik

            //operator =, rezultat je bool tip podatka (true, false)

            bool uvjet = broj == 7;




            //osnovna IF sintaksa - radi sa bool tipom podatka
            if (uvjet)
            {
                Console.WriteLine("Super");
            }
            
            //puna sintaksa IF naredbe
            if(broj>2)
            {
                Console.WriteLine("OK");
            }

            else if(broj ==1)
            {
                Console.WriteLine("Nije dobro");
            }

            else
            {
                Console.WriteLine("NIJE OCJENA");
            }

            //operatori  < >, >=, <=, != se koriste u if-u

            //logicki operatori and, or, not

            // AND:
            // &
            //inace se koristi sa 2 AND (&)

            int i = 5, j = 10;

            if (i > 10 && j > 2)
            {
                Console.WriteLine("Nece se ispisati");
            }

         //OR
         // | (Aaltgr + W)
         
            if (i==4 || j==2)
            {
                Console.WriteLine("Jedno od dvoje");
            }


         //NOT 
         // !

            if (!uvjet)
            {
                Console.WriteLine("Kada gore ne ispise, ovdje ce");
            }


            string grad = "Osijek";

            if(uvjet && i > 10)
            {
                if (grad == "Vukovar")
                {
                    Console.WriteLine("Novi prvoligas");
                }
            }

            if (grad == "Osijek")
            {
                Console.WriteLine("Super");
            }
            else
            {
                Console.WriteLine("OK");
            }


            // INLINE IF

            Console.WriteLine(grad == "Osijek" ? "Super" : "OK"); 

            





        }

    }
}
