using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E16Polimorfizam
{
    public class Ravnatelj : Osoba
    {
        public override void Greska(string poruka)
        {
           
        }

        public override void Log(String poruka)
        {
            Console.WriteLine(poruka);
        }



        public override string Pozdravi()
        {
            return "";
        }
    }
}
