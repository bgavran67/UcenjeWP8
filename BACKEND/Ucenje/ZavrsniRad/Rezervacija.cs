using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.ZavrsniRad
{
    public class Rezervacija
    {
        public int Sifra { get; set; }

        public decimal UkupnaCijena { get; set; }

        public DateTime VrijemeIDatumPrijave { get; set; }

        public Gost Gost { get; set; } = new Gost();

        public Soba Soba { get; set; } = new Soba();
    }
}
