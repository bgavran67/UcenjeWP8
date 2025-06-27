using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18GSALE
{
    //sucelja mogu biti genericka
    public class Smjer : Entitet, IComparable<Smjer>, IObrada //sucelje za usporedivanje (icomparable)
    {
        public string Naziv { get; set; } = "";

        public int CompareTo(Smjer? other)
        {
            if(other == null)
            {
                return 1;
            }
            return Naziv.CompareTo(other.Naziv);
        }

        public string Metoda()
        {
            return "";
        }
        

        public void OdradiPosao()
        {
            Console.WriteLine("SMjer"); 
        }

        public override string ToString()
        {
            return Naziv ?? ""; //ako je naziv null vrati prazno
        }
    }
}
