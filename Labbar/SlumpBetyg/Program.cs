using System;

namespace SlumpBetyg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Slumpa fram ett tal 0-5 
            // Där 0=F, osv
            //skapa en slumpgenerator
            Random tärning = new Random();

            //Kasta tärningen
            int slumptal = tärning.Next(0, 8);
            Console.WriteLine($"slumptalet = {slumptal}");

            //skriv ut betyg 
     /*       if (slumptal == 0)
            {
                Console.WriteLine("Du fick betyget F!");
            }
            if (slumptal == 1)
            {
                Console.WriteLine("Du fick betyget E!");
            }
            if (slumptal == 2)
            {
                Console.WriteLine("Du fick betyget D!");
            }
            if (slumptal == 3)
            {
                Console.WriteLine("Du fick betyget C!");
            }
            if (slumptal == 4)
            {
                Console.WriteLine("Du fick betyget B!");
            }
            if (slumptal == 5)
            {
                Console.WriteLine("Du fick betyget A!");
            }*/

            
            //Alternativ 2
     /*      switch (switch_on)
            {
               case 1:
                    Console.WriteLine("Du fick betyget F!");
                    break;
                case 2:
                    Console.WriteLine("Du fick betyget E!");
                    break;
                case 3:
                    Console.WriteLine("Du fick betyget D!");
                    break;
                case 4:
                    Console.WriteLine("Du fick betyget C!");
                    break;
                case 5:
                    Console.WriteLine("Du fick betyget B!");
                    break;

                default:
                 Console.WriteLine("Du fick betyget A!");
                    break;
            }*/

            // Alternariv 3
            string[] betyg = {"F", "E","E","E", "D", "C", "B", "A"}; // större chans a
            Console.WriteLine($"Du fick {betyg[slumptal]} i slutbetyg") ;
        }
    }
}
