using System;
using System.IO;

namespace projektuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Skapa ett program där användaren får välja om hen vill skapa/skriva över en fil eller läsa in innehållet från en fil. Användaren ska därefter få skriva in namnet på filen. Om användaren valde att skapa/skriva över en fil ska hen sedan få skriva in en sträng som ska sparas i filen, om hen valde att läsa in innehållet från en fil ska filens innehåll visas. Innan du läser in filen ska du undersöka om filen finns.*/
            //Fråga om input 
            Console.Write("VILL DU : \n 1.skapa/skriva över en fil eller \n 2.läsa in innehållet från en fil? \n[skriv endast 1 eller 2]:");
            string val = Console.ReadLine();

            //skriv in filnamnet
            Console.WriteLine("Skriv in namnet på filen:");
            string filnamn = Console.ReadLine(); 

            
            if (val == "1")
            {
                Console.WriteLine("Skriv in innehåll i filen");
                string innehåll = Console.ReadLine();
                File.WriteAllText(filnamn, innehåll);
                Console.WriteLine("Texten är sparad i filen");
            }
            if (val == "2")
            {
                if (File.Exists(filnamn))
                    {
                        string text = File.ReadAllText(filnamn);
                        Console.WriteLine("Här är filens innehåll:");
                        Console.WriteLine(text);                        
                    }
                    else
                    {
                        Console.WriteLine("Filen finns inte!");
                    }
            }
            
            
            
            
            
            
            
            
            
        }
    }
}
