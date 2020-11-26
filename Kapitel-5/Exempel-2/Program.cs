using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be om en text
            Console.Write("Ange en text: ");
            string text = Console.ReadLine();

            // Dela upp texten i separata ord
            string[] orden = text.Split(' ');

            // Loopa igenom Arrayen
           /* for (int i = 0; i < orden.Length; i++)
            {
                Console.WriteLine($"Ord {i}: {orden [i]}");
            }*/

            // Alternativ 2 foreach
            int i = 0; 
            foreach (var ord in orden)
            {
                Console.Write(ord);
                i++;
            }
            //skriv ut antalet ord
            Console.WriteLine(i);
            // eller kan man räknan antal ord med length cw {orden.lenght}
        }
    }
}
