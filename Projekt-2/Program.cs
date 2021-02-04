using System;
using System.IO;

namespace Projekt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarera variabler och initialisera (lägga värde i int)
            int antalBord = 8;
            string filnamn = "centralbord.csv";
            string tomtBordBeskrivning = "0,Inga gäster";
            string[] bordsInformation; // Array för att lagra bokningar

            // Presentera programmet för användren 
            Console.WriteLine("Detta är Centralresturangens bordshanterare");

            //Finns lagringsfilen
            if (File.Exists(filnamn))
            {
                //Läs in alla rader, dvs bordsbokningar
                bordsInformation = File.ReadAllLines(filnamn);
                Console.WriteLine("bokningarna lästes in från fil");
            }
            else
            {
                // skapa en tom bordslista i arrayen 
                // lagra detta i filen
                bordsInformation = new string[antalBord]; //8 nya tomma positioner 

                //fyll arrayen med tomma bord: 0, 1, 2....7
                for (int i = 0; i < antalBord; i++)
                {
                    bordsInformation[i] = tomtBordBeskrivning;
                }

                //Lagra i filen
                File.WriteAllLines(filnamn, bordsInformation);
                Console.WriteLine("fil med bordsinformation saknas, ny fil skapades");
            }
            // SKriv ut Huvudmenyn
            while (true)
            {
                //skriv ut huvudmeny
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Visa alla bord");
                Console.WriteLine("2. Ändra bordsinformation");
                Console.WriteLine("3. Markera att ett bord är ledigt");
                Console.WriteLine("4. Avsluta programmet");
                string menyVal = Console.ReadLine();

                //Hanter menyVal
                switch (menyVal)
                {
                    // visa alla bord
                    case"1":
                    int totaltAntalGäster = 0;
                    for (int i = 0; i < antalBord; i++)
                    {
                       if (bordsInformation[i] == tomtBordBeskrivning)
                       {
                           //Bordet är tomt
                           Console.WriteLine($"Bord{i + 1} - inga gäster");
                       }else
                       {
                           // bordet har en bokning
                           //Plocka ut namn och antal gäster 
                           string[] delar = bordsInformation[i].Split(',');
                           string antalGäster =  delar[0];
                           string namn =  delar[1];

                           //summera alla gäster
                           totaltAntalGäster += int.Parse(antalGäster);

                           //skriv ut information
                          Console.WriteLine($"Bord{i + 1} - Namn: {namn}, antal gäster: {antalGäster}");
                       }
                    }
                      //summera 
                     Console.WriteLine($" Totalt antal gäster: {totaltAntalGäster}");

                    break;
                    
                    case"2":
                    //spara information

                    break;
                    
                    case"3":
                    break;
                    
                    case"4":
                    break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        break;
                }
            }


        }
    }
}
