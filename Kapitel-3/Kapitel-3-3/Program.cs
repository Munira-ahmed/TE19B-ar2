using System;

namespace Kapitel_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta program kan berätta vilka de 5 bästa filmerna" +
    "genom tiderna är. Vilken position vill du veta om?");
string val= Console.ReadLine();

switch (val)
{
    case "1":
        Console.WriteLine("Nyckeln till frihet");
        break;
    case "2":
        Console.WriteLine("Gudfadern");
        break;
    case "3":
        Console.WriteLine("Gudfadern del 2");
        break;
    case "4":
        Console.WriteLine("The Dark Knight");
        break;
    default:
        Console.WriteLine("Schindler's List");
        break;
}
        }
    }
}
