using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.ZavrsniRad
{
    public class PrijevozGostiju
    {
        public int Sifra { get; set; }
        public DateTime DatumPolaska { get; set; } = new DateTime();

        public DateTime DatumOdlaska { get; set; } = DateTime.Now;

        public string? VrstaPrijevoza { get; set; }

        public string? LokacijaPolazista { get; set; } = "";

        public string Dostupnost { get; set; }

        public int BrojPutnika { get; set; }

        public Gost Gost { get; set; } = new Gost();




    }
}
