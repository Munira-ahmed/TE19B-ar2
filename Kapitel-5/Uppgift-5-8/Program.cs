using System;

namespace Uppgift_5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // användaren får skriva in en mening. 
            Console.Write("Skriv in en mening: ");
            string mening = Console.ReadLine();

            //Skapa en array där varje ord i meningen blir ett element i arrayen. 
            string[] orden =  mening.Split(' ');
            //Skriv därefter ut varje ord i meningen på en egen rad.
            foreach (var ord in orden)
            {
                
            }
        }
    }
}
