﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E03Operatori
    {
        public static void Izvedi()
        {

            Console.WriteLine("E03Operatori");


            // + kao operatior nadoljepljivanja (concate)
            string grad = "Osijek";
            string ime = "Edunova";

            Console.WriteLine(grad + " " + ime + " " + 5);

            Console.WriteLine("{0} {1} {2}", grad, ime, 5); //odraduje kao gore ali brze


            //operater modulo %
            Console.WriteLine(8%2); //0

            int b = 9 % 2;
            Console.WriteLine(b);


            //uvecane broja za 1
            int i = 0;

            //uvecaj za 1
            i = i + 1;

            i += 1;

            i++;

            ++i;

            //increment i decrement (++i, i++, --i, i--)

            int k = 1, j = 0;

            k = ++k - j++; // k = 2 - 0, j = 1 
            Console.WriteLine(--k+j++); //sto se ispisuje 1 + 1 = 2














        }










    }
}
