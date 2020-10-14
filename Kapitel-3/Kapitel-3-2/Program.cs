using System;

namespace Kapitel_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket land vann fotbolls VM för damer år 2015?");
            string rättsvar = "usa";
            string svar = Console.ReadLine(); // man gör svaret till bara lowercase
            string småsvar = svar.ToLower();

            
            if (småsvar == rättsvar)
            {
                Console.WriteLine(" Svaret är rätt!");
            }
            if (småsvar != rättsvar)
            {
                Console.WriteLine("Svaret är fel");
            }
        }
    }
}
