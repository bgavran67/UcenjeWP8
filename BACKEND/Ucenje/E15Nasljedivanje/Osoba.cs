﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E15Nasljedivanje
{
    //klasa Object
   public class Osoba : Object
    {
        public int Sifra { get; set; }
        public string Ime { get; set; }= "";
        public string Prezime { get; set; } = "";
        public string? Email { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
