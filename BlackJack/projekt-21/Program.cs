﻿using System;

namespace projekt_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //vem har vunnit senast
            string SenasteVinnaren = "ingen har vunnit ännu";
            Random slump = new Random();

            // Skriv välkomstmeddelande
            Console.WriteLine("Välkommen till 21:an!");

            // deklarera menyVal   
            string menyVal = "0";


            // while (menyval != ”4”)
            while (menyVal != "4")
            {
                // Skriv ut meny
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine();
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programmet");
                // Läs in menyVal
                menyVal = Console.ReadLine();

                // switch menyVal
                switch (menyVal)
                {
                    //"spela en omgång av 21:an"
                    case "1":
                        int datornsPoäng = 0;
                        int spelarensPoäng = 0;
                        Console.WriteLine("Nu kommer två kort dras per spelare");
                        //slump ger 2 slumpmässiga nummer mellan 1 -10 till  både spelare och dator
                        datornsPoäng += slump.Next(1, 11);
                        datornsPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);


                        string kortVal = "";
                        while (kortVal != "n" && spelarensPoäng <= 21)
                        {
                            Console.WriteLine($"Din poäng: {spelarensPoäng}");
                            Console.WriteLine($"Datorns poäng: {datornsPoäng}");
                            Console.WriteLine("Vill du ha ett till kort? (j/n)");
                            string answer = Console.ReadLine();
                            kortVal = answer.ToLower();

                            switch (kortVal)
                            {
                                case "j":
                                    int nyPoäng = slump.Next(1, 11);
                                    spelarensPoäng += nyPoäng;
                                    Console.WriteLine($"Ditt nya kort är värt {nyPoäng} poäng");
                                    Console.WriteLine($"Din totalpoäng är {spelarensPoäng}");
                                    break;

                                case "n":
                                    break;

                                default:
                                    Console.WriteLine("Du valde inte ett giltigt alternativ");
                                    break;
                            }

                        }
                        //spelets slut om datorn eller spelaren har mer än 21 poäng
                        if (spelarensPoäng > 21)
                        {
                            Console.WriteLine("Du förlora! Du har mer än 21.");
                            break; //spelet stannar 
                        }
                        //Datorn dara bara en gån och stannar utan while-loopen här
                        //datorn ska fortsätta dra tills den vinner eller förlorar
                         while (datornsPoäng < spelarensPoäng && datornsPoäng <= 21)
                        {
                            int datornsNyaPoäng = slump.Next(1, 11);
                            datornsPoäng += datornsNyaPoäng;
                            Console.WriteLine($"Datorn drog ett kort värt {datornsNyaPoäng}");
                        }
                        Console.WriteLine($"Din poäng: {spelarensPoäng}");
                        Console.WriteLine($"Datorns poäng: {datornsPoäng}");

                        if (datornsPoäng > 21)
                        {
                            Console.WriteLine("Du vann!");
                            Console.WriteLine("Skriv in ditt namn: ");
                            SenasteVinnaren = Console.ReadLine();
                        }
                        
                   
                        else
                        {
                            Console.WriteLine("Datorn vann!");
                        }

                        break;

                    case "2":
                        //"Visa senaste vinnaren";
                        Console.WriteLine($"senaste vinnaren = { SenasteVinnaren}");
                        break;

                    case "3":
                        Console.WriteLine("SPELETS REGLER!:");
                        Console.WriteLine();
                        Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
                        Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng.");
                        Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
                        Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
                        Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
                        Console.WriteLine("När du är färdig drar datorn kort till den har");
                        Console.WriteLine("mer poäng än dig eller över 21 poäng.");
                        break;

                    case "4":
                        Console.WriteLine("Spelet Avslutas");
                        break;

                    default:
                        Console.WriteLine("Det alternativet är ogiltigt");
                        break;
                }
            
            }
        }
    }
}
