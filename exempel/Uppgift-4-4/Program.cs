using System;

namespace Uppgift_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //slumpa fram ett tal (1-6)
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 7);

            //Deklarera variabelns gissning
            int gissning = 0;

            //Loopar tills vi får rätt tal
            while (gissning != slumptal)
            {
                //fråga användaren vad hen gissar
                Console.WriteLine("Gissa ett tal (1-6)");

                //läs in användarens gissning
                //gissning = int.Parse(Console.ReadLine());
                //en säkrare inmatning
                string input = Console.ReadLine();

                //försöker översätta till ett heltal, try.parse visar om det går eller inte
                if (int.TryParse(input, out gissning))
                {
                    Console.WriteLine("vad bra att du matade in ett tal!");

                     //KOlla on gissningen är fel
                if (gissning != slumptal)
                {
                    Console.WriteLine("Fel svar, försök igen");
                }
                }
                else
                {
                    Console.WriteLine("Nej! jag bad om ett tal, försök igen.");
                }

            }
            // Rätt svar
            Console.WriteLine("Dy har gissat rätt");
        }
    }
}
