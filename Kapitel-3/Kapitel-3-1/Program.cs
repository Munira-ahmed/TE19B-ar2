using System;

namespace Kapitel_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());

            if (50 <= age)
            {
                Console.WriteLine("Du är minst 50 år och kan delta");
            }
            if (50> age)
            {
                Console.WriteLine("Du är för ung för att delta");
            }
        }
    }
}
