using System;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fråga hur många tärningar användaren vill kasta
            Console.WriteLine("Hur många tärningar vill du kasta?");
            int antal = int.Parse(Console.ReadLine());

            //Fråga hur många sidor varje tärning har 
            Console.WriteLine("Hur många sidor har tärningarna?");
            int sidor = int.Parse(Console.ReadLine());

            //kasta tärningen ett antal gånger 
            //För varje kast får man ett slumptal med så många sidor 
            Random tärning = new Random();
            
            for (int i = 0; i < antal; i++)
            {
               
                int slumptal = tärning.Next(1, sidor);

                //Skriv ut varje kast
                Console.WriteLine($"kast {i+1} fick du {slumptal}");
        
            }

        }
    }
}
