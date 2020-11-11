using System;

namespace CeasarKrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ange en text 
            Console.Write("Ange en text: ");
            string text = Console.ReadLine();

            // Loopa igenom inmatad text bokstav för bokstav
            string krypteradText = "";
            int textLängd = text.Length;
            Console.WriteLine($"texten är {textLängd} tecken lång");
            //Nyckel 
            string nyckelString = Console.ReadLine();

            int nyckel = 0;
            while (!int.TryParse(nyckelString, out nyckel))
            {

                Console.WriteLine("Du måste mata in ett tal, Ange en nyckel mellan 1-9");
                nyckelString = Console.ReadLine();
            }
            for (int i = 0; i < textLängd; i++)
            {
                Console.WriteLine($"Loop nr {i}");

                //Plocka ut bokstav på position i
                char bokstav = text[i];
                Console.WriteLine($"Bokstaven på position {i} är {bokstav}");

                //ASCII värdet för ett tecken 
                int ascii = (int)bokstav;
                Console.WriteLine($"Bokstaven {bokstav} har ASCII-värdet {ascii}");

                //Ceasar Kryptering
                ascii += nyckel;

                //plocka motsvarande tecken enligt ASCII tabellen
                char KrypteradBokstav = (char)ascii;
                Console.WriteLine($"Bokstaven {bokstav} krypteras till {KrypteradBokstav}");

                // samla ihop bokstäverna 
                krypteradText += KrypteradBokstav.ToString();

            }
            Console.WriteLine($"Den krypterade texten är: {krypteradText}");
        }
    }
}
