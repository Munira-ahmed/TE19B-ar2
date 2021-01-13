using System;

namespace Uppgift_5_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Skapa ett program som innehåller en array med minst 5 namn. 
            Använd en loop för att gå igenom arrayen och sedan skriva ut det namn som kommer först i bokstavsordning.*/
            string [] namner = {"Munira", "Anna","Benjamin", "Ikram", "Ron" };

            //.compareto eller sort
            Array.Sort(namner);

            foreach (var namn in namner)
            {
                Console.WriteLine(namn);
            }
        }
    }
}
