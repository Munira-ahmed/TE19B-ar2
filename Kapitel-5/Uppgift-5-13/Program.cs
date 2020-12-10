using System;

namespace Uppgift_5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());
            int[] talLista = new int[antal];
            Console.WriteLine($"Skriv in {antal} heltal");

            for (int i = 0; i < talLista.Length; i++)
            {
                talLista[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Här är heltalen du skrev in:");

            foreach (var heltal in talLista)
            {
                
                Console.WriteLine($" {heltal}");
            }
        }
    }
}
