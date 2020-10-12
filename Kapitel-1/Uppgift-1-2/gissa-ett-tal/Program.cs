using System;

namespace gissa_ett_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            //slumpa fram ett tal
            Random slump = new Random();
            int slumptal = slump.Next(1, 7);

            // läs in en gissning
            Console.WriteLine("gissa ett tal (1-6)?");
            int gissning = int.Parse(Console.ReadLine());


            //kolla on gissningen är korrekt
            if (gissning == slumptal)
            {
                Console.WriteLine("Rätt svar");

            }
            else
            {
                Console.WriteLine("fel svar");
            }
            //hur gör man en loop?
            for (int i = 5 - 1; i >= 0; i--) ; //i ++ = i+1
            {
                string i = null;
                Console.WriteLine("Loop nr" + i);
            }
        }
    }
}
