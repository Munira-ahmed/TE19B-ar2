using System;

namespace exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Slumpa fram ett tal 1-6
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 7);

            // upprepa tills rätt svar gissats
            while (true)
            {
                //Läs in användarens gissning
                Console.WriteLine("Gissa ett tal (1-6)?");
                int gissning = int.Parse(Console.ReadLine());

                //Har användaren gissat rätt?
                if (gissning == slumptal)
                {
                    Console.WriteLine("Rätt!");
                    break;
                }
                else
                {
                    Console.WriteLine("Fel!");
              }
            }
        }
    }
}
