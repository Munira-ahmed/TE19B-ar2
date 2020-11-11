using System;

namespace Kapitel_4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket är Europas folkrikaste land?");
            //läs in användarens svar
            string input = Console.ReadLine(); 
            string svar = input.ToLower();
            
            // är svaret rätt?
           
            for (int i = 0; i < 4; i++)
            {
                 if (svar == "tyskland")
            {
                Console.WriteLine("Svaret är rätt");
                break;
                
            }
            else
            {
                Console.Write("Försök igen: ");
                svar = Console.ReadLine();
            }

        }
           Console.WriteLine("FEL : rätt svar var Tyskland");
        }
    }
}
