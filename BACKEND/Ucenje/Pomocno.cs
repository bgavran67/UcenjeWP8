

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

    }
}
