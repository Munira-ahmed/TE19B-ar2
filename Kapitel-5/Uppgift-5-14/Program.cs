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

            Console.Write("Vilken typ av fråga vill du svara på?:" );
            string typ = Console.ReadLine();

            if ( typ == 1)
            {
                
            }

            if ( typ == 2)
            {
                
            }

            if ( typ == 3)
            {
                
            }

            if ( typ == 4)
            {
                
            }
             
        }
    }
}
