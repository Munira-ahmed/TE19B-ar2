using System;

namespace Uppgift_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket år är det?");

            int år = int.Parse(Console.ReadLine());
            int framtid = 2100 - år;

            Console.WriteLine("Det är " + framtid + "år kvar till år 2100");
        }
    }
}
