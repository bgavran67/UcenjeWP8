

namespace Ucenje
{
    class Pomocno
    {

        public static string UcitajString(string poruka)
        {
            string s;
            for (; ; )
            {
                Console.WriteLine(poruka + ": " );
                s = Console.ReadLine().Trim();
                if(s.Length > 0)
                {
                    return s;
                }
                Console.WriteLine("Obavezan unos!");
            }
        }

        public static bool isCijeliBroj(string s)
        {
            try
            {
                int.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int ucitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pokusaj ponovno.");
                }
            }

        }





        /// <summary>
        /// Učitava decimalni broj s konzole.
        /// Prikazuje poruku korisniku i zahtijeva unos decimalnog broja.
        /// Ako unos nije broj, ispisuje poruku o pogrešci i ponavlja unos.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni broj.</returns>
        public static decimal UcitajDecimalniBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return decimal.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pokušajte ponovo");
                }
            }
        }







   

    }
}
