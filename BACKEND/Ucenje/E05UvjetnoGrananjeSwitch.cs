using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E05UvjetnoGrananjeSwitch
    {
        public static void Izvedi()
        {

            Console.WriteLine("E05UvjetnoGrananjeSwitch");

            // SWITCH radi s tipovima podataka: int, string, char,...

            Console.Write("Unesi ocjenu brojem: ");
            int broj = int.Parse(Console.ReadLine());

            switch (broj)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;

                case 2:
                    Console.WriteLine("Dovoljan");
                    break;

                case 3:
                    Console.WriteLine("Dobar");
                    break;

                case 4:
                    Console.WriteLine("Vrlo Dobar");
                    break;

                case 5:
                    Console.WriteLine("Izvrstan");
                    break;

                case 6:

                case 7:
                    Console.WriteLine("Pa i to bi mogle biti ocjene ali nisu");
                    break;

                default:
                    Console.WriteLine("nije ocjena");
                    break;
            }


        }
    }
}
