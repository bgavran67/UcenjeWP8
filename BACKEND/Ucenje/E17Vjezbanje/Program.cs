using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Program
    {
        public Zadatak1 Zad1 { get; set; }
        public Zadatak2 Zad2 { get; set; }

        public Program()
        {
            //zadatak konstruktora je konstruirati potrebne zavisnosti
            Zad1 = new Zadatak1();
            Zad2 = new Zadatak2();
            Izbornik();

        }

        private void Izbornik()
        {
            Console.WriteLine("\n******************************");
            Console.WriteLine("********** IZBORNIK ************");
            Console.WriteLine("0. Izlaz");
            Console.WriteLine("1. Zbrajanje dvaju brojeva");
            Console.WriteLine("2. Izracun povrsine");
            Console.WriteLine("******************************");
            OcitajOdabir();
        }

        private void OcitajOdabir()
        {
            //1. nacin
            int odabir = Pomocno.ucitajCijeliBroj("Unesi redni broj programa");
            switch (odabir)
            {
                case 0:
                    Console.WriteLine("Dovidenja");
                    break;
                case 1:
                    Zad1.Izvedi();
                    //Console.WriteLine("1. zadatak");
                    break;
                case 2:
                    Zad2.Izvedi();
                    break;
                default:
                    Console.WriteLine("Ne postoji taj program");
                    Izbornik();
                    break;
            }
            if (odabir != 0)
            {
                Izbornik();
            }

            //2. nacin
            //switch (Pomocno.ucitajCijeliBroj("Unesi redni broj programa"))
            //{
            //      case 0:
            //          Console.WriteLine("Dovidenja");
            //          break;
            //      case 1:
            //          //kreiranje istance klase Zadatak1
            //          Console.WriteLine("1. zadatak");
            //          Izbornik();
            //          break;
            //      default:
            //          Console.WriteLine("Ne postoji taj program");
            //          Izbornik();
            //          break;
            //}







        }
    }
}
