using System;

namespace Uppgift_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett tal!:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("skriv in ett annat tal!:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Medelvärdet är "+((num1+num2)/2));
        }
    }
}
