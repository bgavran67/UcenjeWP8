using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    class E10ForEachPetlja
    {

        public static void Izvedi()
        {
            Console.WriteLine("ForEachPetlja");

            Console.Write("Unesi ime grada: ");
            string grad = Console.ReadLine();

            //ispisi svako slovo grada jedno ispod drugog
            for(int i=0; i< grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }


            Console.WriteLine("**********************");
            // u slucajevima kada idemo od pocetka do kraja (vecinu puta)
            foreach(char z in grad)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine("**********************");

            int[] brojevi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(int i in brojevi)
            {
                Console.WriteLine(i);
            }








        }



    }
}
