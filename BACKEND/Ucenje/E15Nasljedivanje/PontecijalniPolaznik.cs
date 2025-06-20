using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E15Nasljedivanje
{
    //sve iz osobe mi dogovara, a od osobe ne mogu napraviti klasu jer je Osoba apstraktna
    public class PontecijalniPolaznik : Osoba
    {
        public string Napomena { get; set; }
    }
}
