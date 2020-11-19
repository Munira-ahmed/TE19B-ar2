using System;

namespace Uppgift_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
           //en array som ska innehålla namnen på tre städer 
           //skriv in två av namnen i programmets kod

           string[] städer = new string[3];
           städer[0] = "stockholm";
           städer[1] = "tokyo";

           Console.WriteLine("skriv in en stad");
           städer[2] = Console.ReadLine();

           Console.WriteLine("Här är tre städerna");
           Console.WriteLine($"{städer[0]}, {städer[1]} och {städer[2]}");
           
        }
    }
}
