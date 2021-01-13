using System;

namespace Uppgift_5_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapa två arrayer 
            string[] frågor = {"I vilken kontinent ligger Sverige?",
             "Hur många sidor har en romb? Svara med nummer", "Vilket år dog gustav vasa? svara med nummer",
             "Vad är förkortningen till world health organization?"};

            string[] svar = { "europa", "4", "1560" , "who"};

            Console.WriteLine("Det här är en frågesport!" );
            Console.WriteLine();  

            Console.WriteLine(" 1. Geografisk" );
            Console.WriteLine(" 2. Matematisk" );
            Console.WriteLine(" 3. Historisk" );
            Console.WriteLine(" 4. Samhällskunskap" );

            Console.WriteLine("Vilken typ av fråga vill du svara på?" );
            Console.Write("Välj en fråga (1 - 4):");
            int frågeIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine(frågor[frågeIndex]);
            string användarensSvar = Console.ReadLine().ToLower();

            if (användarensSvar == svar[frågeIndex])
            {
                Console.WriteLine("Du svarade rätt!");
            }
            else
            {
                Console.WriteLine("Du svarade fel");
            }
        }
    }
}
