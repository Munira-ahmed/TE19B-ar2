using System;

namespace Uppgift_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //skapa en array med minst 5 årtal
            int[] årtal = { 1990, 2000, 2020, 1850, 1500 };

            //Fråga användaren om ett åratal att söka
            Console.Write("skriv in ett årtal: ");
            int gissning = int.Parse(Console.ReadLine());

            //flagga
            bool flagga = false;

            //skriv ut alla index om årtalet hittades i arrayen
            for (int i = 0; i < årtal.Length; i++)
            {
                if (gissning == årtal[i])
                {
                    Console.WriteLine($"Din gissning {årtal[i]} finns i Arrayen");
                    flagga = true;
                }

            }
            if (!flagga) //flagga == false
            {
                Console.WriteLine("Årtalet kunde inte hittas");
            }
        }
    }
}
