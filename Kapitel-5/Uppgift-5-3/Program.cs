using System;

namespace Uppgift_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapa ett program som innehåller en array med minst 8 heltal
            int[] talen = {9, 45, 67, 80, 2, 90, 76, 3, 7};

             // skapa en variabel som ska innehålla max-värdet
             int max = 0;
            //gå igenom arrayen med hjälp av en loop
            for (int i = 0; i < talen.Length; i++)
            {
                //hitta det största talet i arrayen genom att jämföra talen
                if ( talen[i] > max)
                {
                    max = talen [i];
                }

            }
            Console.WriteLine($"Det största talet är {max}");
        }
    }
}
