using System;

namespace uppgift4
{
    class Program
    {
      

        static void Main(string[] args)
        {
            //ska räkna ner från 50 till 1. i = 50 och i<0
            int i = 50;         // glöm inte; på slutet
                                // är en int
            while (i > 0) ;      // medan i är större än 1 ska loopen fortsätta
            {
                Console.WriteLine(i); //inte ("i") annars tolkas i som en string
                i--;                   // minska med 1 alltså i-1
            }


        }
    }
}
