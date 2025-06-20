using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E16Polimorfizam
{
    public class Polaznik : Osoba
    {
        public string? Telefon { get; set; }

        public override void Greska(string poruka)
        {
            //todo: Zavrsi;
            //pojam tehnicki dug: technical debt
        }

        public override string Pozdravi()
        {
            return new StringBuilder()
                .Append("Dobar dan")
                .Append( Ime)
                .Append(" , polaznice")
                .Append( Telefon)
                .ToString();
        }









    }
}
