using System;

namespace Uppgift_5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Hur många sporter vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());

            // new string[antal]
            string[] sporter = new string[antal];

            for (int i = 0; i < sporter.Length; i++)
            {
                Console.Write("skriv in en sport:");
                sporter[i]= Console.ReadLine();
            }
            Console.WriteLine("sporterna du skrev in är:");
            for (int i = 0; i < sporter.Length; i++)
            {
                
                 Console.WriteLine(sporter[i]);
            }
           
        }
    }
}
