using System;
using System.IO;

namespace Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentera programmet
            Console.WriteLine("Program för att hitta länder matchande sökterm.");
            Console.WriteLine("Program listar land och landskod.");

            // Läs in alla rader från textfilen countries.csv
            if (File.Exists("countries.csv"))
            {
                //Läser in alla rader 
                string[] rader = File.ReadAllLines("countries.csv");

                //ber användaren om sökterm
                Console.WriteLine("Ange sökterm (Avsluta med return)");
                string sökterm= Console.ReadLine();
                
                //Loopa igenom alla rader
                //foreach
                foreach (var rad in rader)
                {
                    // söka i den röda fältet 
                    //Console.WriteLine(rad); // rad är en string
                    string[] delar = rad.Split(',');
                    
                    //Console.WriteLine(delar[1]);
                    
                    if (delar[1].Substring(0, sökterm.Length) == sökterm)
                    {
                       Console.WriteLine(delar[1]); 
                    }
                }
            }

        }
    }
}