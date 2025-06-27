using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18GSALE
{
    public class Obrada<T> // <T> je oznaka type a moze biti bilo koje slovo ili niz slova
                           //genericka oznaka
    {
        public T? PredmetObrade { get; set; }

        [Obsolete("Ovo vise nemoj koristiti")]

        public void Posao()
        {
            Console.WriteLine("Obradujem {0}", PredmetObrade);
        }
    }
}
