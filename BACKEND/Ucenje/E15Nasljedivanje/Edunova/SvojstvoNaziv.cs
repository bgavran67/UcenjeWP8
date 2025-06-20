using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E15Nasljedivanje.Edunova
{
    public abstract class SvojstvoNaziv : Entitet
    {
        public string Naziv { get; set; } = " ";
        public DateTime? DatumPokretanja { get; set; }
        public bool Aktivan { get; set; }
    }
}
