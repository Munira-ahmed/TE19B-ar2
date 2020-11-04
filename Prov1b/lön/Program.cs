using System;

namespace lön
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Det här programmet ska ränka ut din Nettolön.");

            Console.WriteLine("svara genom att trycka på nummer 1,2,3,4");
            Console.WriteLine("1. tjänar du 10000 eller mindre");
            Console.WriteLine("2. tjänar du 10000 till 145000");
            Console.WriteLine("3. tjänar du 145000 till 515000");
            Console.WriteLine("4. tjänar du 515000 och mer");

            string val = Console.ReadLine();

            Console.WriteLine("Hur mycket tjänar du innan skatt i kr?");
            string bruttolönString = Console.ReadLine();

            int bruttolön = int.Parse(bruttolönString);


            if (val == "1")
            {
                Console.WriteLine("Du tjänar " + bruttolön + " och har marginalskatten" + " 8%");
                int svar1 = bruttolön * (100 - 8) / 100;
                Console.WriteLine($"Du tjänar {svar1} kr efter skatt");

            }

            else if (val == "2")
            {
                Console.WriteLine("Du tjänar " + bruttolön + " och har marginalskatten" + " 22%");
                int svar2 = bruttolön * (100 - 22) / 100;
                Console.WriteLine($"Du tjänar {svar2} kr efter skatt");

            }
            else if (val == "3")
            {
                Console.WriteLine("Du tjänar " + bruttolön + " och har marginalskatten" + " 33%");
                int svar3 = bruttolön * (100 - 33) / 100;
                Console.WriteLine($"Du tjänar {svar3} kr efter skatt");

            }
            else (val == "4")
            {
                Console.WriteLine("Du tjänar " + bruttolön + " och har marginalskatten" + " 53%");
                int svar4 = bruttolön * (100 - 53) / 100;
                Console.WriteLine($"Du tjänar {svar4} kr efter skatt");

            }
        }

    }
}