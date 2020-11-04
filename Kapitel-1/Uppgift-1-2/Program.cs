using System;

namespace Exempel_1._1___Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
           int i = 4;
         do
         {
            Console.WriteLine($"i={i}");
            i++;
        } while (i > 4 && i < 10);
        }
    }
}