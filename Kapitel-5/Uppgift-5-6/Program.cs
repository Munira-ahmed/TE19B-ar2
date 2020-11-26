using System;

namespace Uppgift_5_6
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] städer = new string[5];


            for (int i = 0; i < städer.Length; i++)
            {
                Console.Write("Skriv in 5 städer:");
                städer[i] = Console.ReadLine();
            }
            
            foreach (var stad in städer)
            {
               Console.WriteLine(stad);
            }
        }
    }
}
