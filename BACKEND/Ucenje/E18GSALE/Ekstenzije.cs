using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18GSALE
{
    public static class Ekstenzije
    {
        //ekstenzije su metode koje mozemo nakaciti na bilo koji tip podatka za koji ekstenzija je napisana
        //on je STATICNA metoda - static
        public static void EdunovaProvjera(this string s)
        {
            Console.WriteLine(s.Substring(2,4)); //kreni od indexa 2 do indexa 4 ispisati ce  -cuno- od Racunovodstvo
        }

        public static int Broj(this IObrada obrada)
        {
            string s = obrada.Metoda();
            return s.Length;
        }
    }
}
