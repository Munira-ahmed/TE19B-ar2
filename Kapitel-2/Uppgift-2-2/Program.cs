using System;

namespace Uppgift_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //fråga och input
            Console.WriteLine("Vilket år är det?");
            string yeartoday = Console.ReadLine();
            //konvertera input
            int intyear = int.Parse(yeartoday);
            //skapa en variabel till svaret
            int year = intyear + 10;

            Console.WriteLine("Om 10 år är der år" + year);

        }
    }
}
