using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.ZavrsniRad
{
    public class Soba
    {
        public int Sifra { get; set; }
        public string TipSobe { get; set; } = "";

        public decimal Cijena { get; set; }

        public string? Dostupnost { get; set; }

        public double BrojSobe { get; set; }
    }
}
