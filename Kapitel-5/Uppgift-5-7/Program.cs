using System;

namespace Uppgift_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en array med minst 5 heltal.
            
            Console.Write("Summan på heltalen är: ");
            int[] talen ={12, 56, 7, 100, 68, 70};
    
            // Beräkna summan av alla heltal i arrayen med hjälp av en foreach-loop.
            int summa =0;
           foreach (var tal in talen)
           {
             summa += tal;
           }
           Console.WriteLine(summa);
        }
    }
}
