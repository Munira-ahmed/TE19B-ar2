using System;

namespace Uppgift_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken stad kommer du ifrån:");
            string stad = Console.ReadLine();

            Console.WriteLine("Vad är ditt resmål");
            string resmol = Console.ReadLine();

            Console.WriteLine("Hej,"+ stad +"-bo. Jag hoppas du får resa till \n"+ resmol);
        }
    }
}
