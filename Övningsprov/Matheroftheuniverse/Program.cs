using System;

namespace Matheroftheuniverse
{
    class Program
    {
        static void Main(string[] args)
        {

            //Deklarera gissning och svar
            int gissning = 0;
            int svar = 7;

            //Loop medan svaret är fel
            while (gissning != svar)
            {
                //Fråga
                Console.WriteLine("Vad är X om X*6 = 42");
                //input ska va string för att man ska försöka omvandla den med try.parse 
                //Använda out för att få tillbaka värdet från gissning
                string input = Console.ReadLine();

                //Om gissningen är ett tal. använda int.Parse och out
                if (int.TryParse(input, out gissning))
                {
                    Console.WriteLine("vad bra att du matade in ett tal!");
                    if (gissning != svar)
                    {
                        Console.WriteLine($"Fel svar: {gissning}*6 = {gissning * 6}");
                    }

                }
                  if (gissning == svar)
                {
                    Console.WriteLine("Rätt svar!");
                }
                
            }
            
                
        }

    }
}
