using System;

namespace Uppgift_5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = {
            "Skapa en array",
            "Kalla den meningar",
            "Det går bra hittils",
            "Använd foreach loopen",
            "Det är svårt att hitta bra meningar..."};

            foreach (var mening in meningar)
            {
                Console.WriteLine(mening);
            }
        }
    }
}
