using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak2
    {

        private int brojIzvodenja = 1; 

        public void Izvedi()
        {
            brojIzvodenja++;


            decimal pd = Pomocno.UcitajDecimalniBroj("Unesi duljinu: ");
            decimal ps = Pomocno.UcitajDecimalniBroj("Unesi sirinu: ");
            
           
            Console.WriteLine("{0} * {1} = {2}", pd, ps, pd * ps);


        }
    }
}
