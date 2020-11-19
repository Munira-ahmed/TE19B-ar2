using System;

namespace Uppgift_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] åldrar = new int[100];
            int antal = 0;
            //Man ska upprepa inmatning  = loop
            for (int i = 0; i < åldrar.Length; i++)
            {
                Console.WriteLine("Ange en ålder:");
                åldrar[i] = int.Parse(Console.ReadLine());
                
                //fråga användear en om de vill fortsätta
                Console.WriteLine("vill du lägga till en ålder? j/n");
                string svar = Console.ReadLine();

                //Om nej avsluta loopen
                if (svar == "n")
                {
                    break;
                }

                //Om  åldrar = 100. programmet har inte plats
                if (i == 99)
                {
                    
                    Console.WriteLine("programmet har inte plats för fler åldrar");
                    break;
                }
            }
            
            //programmet ska skriva ut alla åldrar.
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine(åldrar[i]);
            }
             
          
        }
    }
}
