using System;
using System.IO;

namespace Filhantering_2
{
    class Program
    {
        static void Main(string[] args)
        {

              // FIlnamnet 
            string filnamn = "./animals.txt";
            // Läs in alla rader
            string[] rader = File.ReadAllLines(filnamn);

             Console.WriteLine("Ange en bokstav mellan A - Z. sökterm: ");

            string sökterm = Console.ReadLine().ToLower();
           
           // Loopa igenom arrayen 
            int counter = 1;
            foreach (var rad in rader)
            {
                //kolla om den första bokstaven = söktermen
                if (rad.Substring(0, 1) == sökterm)
                {
                 Console.WriteLine(counter + ": " + rad );
                 counter++;
                }
               
            }
             Console.WriteLine($"det finns: {counter-1} djur");
           
            
        }
    }
}
