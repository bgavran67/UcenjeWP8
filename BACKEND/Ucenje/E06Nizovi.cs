using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E06Nizovi
    {
        public static void Izvedi()
        {


            Console.WriteLine("E06Nizovi");

            int sijecanj, veljaca, ozujak /* ...*/ ;

            // nizovi - jednodimenzionalni
            // eng. Arrays
            // hrv. i Polja
            //definiraju se sa uglatom zagradom []

            int[] temp = new int[12]; //deklaracija i konstruiranje

            //niz ima index (0) i vrijednost (-1)
            temp[0] = -1; //sijecanj
            temp[1] = 1; //veljaca
            //...
            temp[temp.Length - 1] = 1; //prosinac

            Console.WriteLine(temp);

            Console.WriteLine(string.Join(",",temp));

            Console.WriteLine(temp[1]);


            //niz stringova

            string[] gradovi = new string[3];

            gradovi[0] = "Osijek";
            gradovi[1] = "Zagreb";
            gradovi[2] = "Donji Miholjac";
            //gradovi[3] = "Visnjevac"; System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

            Console.WriteLine(gradovi[2]);

            string ime = "Edunova";

            //ispisite iz varijable ime slovo v

            Console.WriteLine(ime[5]);

            //kraca sintaksa kreiranja niza s vrijednoscu
            double[] iznosi = { 2.3, 4.7, 1.2, 8.4 };

            // dvodimenzionalni nizovi
            int[,] tablica =
            {

                {1,2,3 },
                {4,5,6 },
                {7,8,9 }

            };

            //ispisati broj 6
            Console.WriteLine(tablica[1,2]);

            //zamjeni 4 s brojem 17
            tablica[1, 0] = 17;

            //za ispis mi trebaju petlje


            // trodimenzionalni niz

            int[,,] kocka = new int[10, 10, 10]; //mogu pohraniti 1000 vrijednosti

            // cetverodimenzionalni niz - tesaarect



            //multiverse
            int[,,,,,,,] multiverse;























        }

    }
}
