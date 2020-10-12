using System;

namespace Uppgift_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur högt kan du höjdhoppa i meter?");
            //konvertera input till double
            
            double hojd = double.Parse(Console.ReadLine());

            //variabel för differensen mellan höjderna
            double hopp = 2.45-hojd;

            //sist
            Console.WriteLine("Du är " + hopp +" m ifrån världsreckordet i höjdhopp");
        }
    }
}
