using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E11Z01
    {
        public static void Izvedi()
        {

            Console.WriteLine("E11Z01");

            //za ucitani cijeli broj, program ispisuje da li je paran ili ne

            int b;
            for (; ; )
            {
                Console.Write("Unesi cijeli broj: ");
                try
                {
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Pokusajte ponovno.");
                }
            }

            if (b % 2 == 0)
            {
                Console.WriteLine("Uneseni broj {0} je paran", b);
            }
            else
            {
                Console.WriteLine("Uneseni broj {0} je neparan", b);
            }




        }
    }
}
