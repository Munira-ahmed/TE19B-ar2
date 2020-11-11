using System;

namespace Slump
{
    class Program
    {
        static void Main(string[] args)
        {
            //gissa ett tal
            Console.WriteLine("gissa ett tal mellan 1 - 10");
            int svar = int.Parse(Console.ReadLine());

            Random tärning = new Random();

            //slump tal från 0 - 10
            int slumptal = tärning.Next(1,11);
            
            Console.WriteLine($"talet är {slumptal}");
           
           //om användaren vinner
            if (slumptal == svar)
            {
                Console.WriteLine("du vann!");
            }
            //Annars
            else
            {
                Console.WriteLine("Du förlorade!");
            } 

        }
    }
}
