
namespace Ucenje
{

    //ovo je unutar namespace

    class E02Varijable
    {
        //ovo je unutar klase

        public static void Izvedi()
        {
            //ovo je unutar metode, pisi nakon ovog komentara

            Console.Write("Unesi svoje ime: ");


            //deklaracije varijable
            //tip podatka i ime

            string ime;

            //dodijeljivanje vrijednosti varijabli
            ime = Console.ReadLine();

            //ispisivanje sadrzaja varijable
            Console.WriteLine(ime);

            Console.WriteLine(ime[0]); //1. znak unesenog imena
            
            // string je niz znakova i prvi znak u tom nizu se nalazi na indeksu 0


            //deklariranje i dodijeljivanje u istoj liniji
            char znak = '@'; //ide pod '', moze sadrzavati samo jedan znak

            Console.WriteLine(znak);

            //znakovi su brojevi prema ASCII tablici
            Console.WriteLine((int)znak); //int je cast

            int cijeliBroj = int.MaxValue;

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(cijeliBroj+1);


            Console.Write("Unesi broj cipela: ");

            int brojCipela = int.Parse(Console.ReadLine());

            Console.WriteLine(brojCipela+1);


            bool logickiTip = true; //druga vrijednost - false
            
            float decimalniBroj = 3.14f;

            double velikiDecimalniBroj = 3.14;

            decimal db = 3.14M; 









            //slijedi kraj metode, pisi iznad ovog komentaraa
        }







    }
}
