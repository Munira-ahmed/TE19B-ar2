using System;

namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett nummer:");
            float num1 = float.Parse(Console.ReadLine());

             Console.WriteLine("Skriv in ett annat nummer:");
            float num2 = float.Parse(Console.ReadLine());

            float summa = num1+num2;
            float produkt = num1*num2;

            Console.WriteLine("Summan blir: " + summa);
            Console.WriteLine("Produkten blir: " + produkt);
        }

    }
}
