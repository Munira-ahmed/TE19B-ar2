using System;

namespace Kapitel_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal.:");
            //mata in talet i string 
            string talString = Console.ReadLine();
            //deklareras
          int  siffersumma=0;
           for (int i = 0; i < talString.Length; i++)
           {
               string tal = talString[i].ToString();
               
               // talen behöver vara int
               int nummer = int.Parse(tal);

               siffersumma += nummer;
           }
          Console.WriteLine($"{siffersumma}");

        }
    }
}
