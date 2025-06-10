using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E08WhilePetlja
    {


        public static void Izvedi()
        {

            Console.WriteLine("E08WhilePetlja");

            // while radi sa bull tipom podatka

            // bezkonacna petlja
            while (true)
            {

                Console.WriteLine("Ispis iz bezkonacne petlje nakon cega je break");
                break;
            }

            Console.WriteLine("**************************************************");

            int i = 10;
            //u while se ne mora uci
            while (i < 10)
            {
                Console.WriteLine(i++);
            }

            Console.WriteLine("**************************************************");

            i = 0; //resetiram jednu te istu varijablu
            while (i < 10)
            {
                Console.WriteLine(++i);
            }

            Console.WriteLine("**************************************************");

            i = 0;
            int j = 1;
            while (i<10 && j == 1) //moze ici i || te !
            {

                Console.WriteLine(i++);

            }

            //continue i break rade isto kao i u for
            // gnjezdenje je isto kao u for, moze se kombinirati for i while

            while (i > 10)
            {

                while (j == 10)
                {

                    //kako prekinuti petlju while (i>10)?
                    goto labela;


                }

            }

            labela:
            Console.WriteLine("Gotov");



        }
    }
}
