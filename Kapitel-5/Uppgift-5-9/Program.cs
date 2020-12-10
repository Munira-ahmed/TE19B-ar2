using System;

namespace Uppgift_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // användaren får skriva in en rad med tal
            Console.Write("Skriv in en rad av olika tal separerade med plustecken:");
            string input = Console.ReadLine();

            string[] talen = input.Split('+');

            //deklarera summa i förväg
            int summa = 0;
            //Loopa igenom arrayen av tal 
            for (int i = 0; i < talen.Length; i++)
            { 
                //använd varia
                int intTal = int.Parse(talen[i]); 

                summa += intTal;
            }
            // summan av alla talen.
            Console.WriteLine(summa);
        }
    }
}
