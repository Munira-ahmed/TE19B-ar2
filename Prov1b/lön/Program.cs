using System;

namespace lön
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Skapa ett program som räknar lönen, sk nettolön, efter marginalskatten. Marginalskatten räknas ut baserat på bruttolönen.*/
            Console.WriteLine("Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.  Marginalskatten räknas ut baserat på din bruttolön. Med bruttolön avses din årslön före skatt.");
            string flagga = "j";
            while (flagga == "j")
            {
                //Först matar användaren in bruttolönen (i kr)

                int bruttoLön = 0;
                while (bruttoLön <= 0)
                {
                    Console.Write("Ange din bruttolön i kronor:");
                    string StringbruttoLön = Console.ReadLine();
                    bool flaggaLön = int.TryParse(StringbruttoLön, out bruttoLön);
                    if (flaggaLön == false)
                    {
                        Console.WriteLine("Skriv in ett heltal");
                        
                    }
                    if (bruttoLön <= 0)
                    {
                        Console.WriteLine("Bruttolön måste vara > 0 kr!");
                        
                    }
                }

                //Därefter räknas Marginalskatten ut 
                int marginalskatt = 0;
                if (bruttoLön < 10000)
                {
                    marginalskatt = 8;
                }
                 else if (bruttoLön < 145000)
                {
                    marginalskatt = 22;
                }

                else if ( bruttoLön < 515000)
                {
                    marginalskatt = 33;
                }

                else 
                {
                    marginalskatt = 53;
                }
                int nettoLön = bruttoLön * (100 - marginalskatt) / 100;

                // Nettolönen presenteras för användaren
                Console.WriteLine($"Uträkning baserad på bruttolön {bruttoLön} kr gav nettolönen {nettoLön} kr.");

                //Fråga om användaren vill göra en ny beräkning. Om Ja, börjar programmet om.
                Console.Write("Vill du göra en ny beräkning? (j/n)");
                flagga = Console.ReadLine().ToLower();

            }

        }

    }
}

/*
 float Längd = 0.0;
                while (BMI <= 0)
                {
                    //Användaren in längd (i cm) och vikt (i kg).( datatypen float)
                    Console.Write("Ange din längd i m:");
                    string StringLängd = Console.ReadLine();
                    //använda tryParse
                    bool flaggalängd = float.TryParse(StringLängd, out Längd);

                    if (flaggalängd == false)
                    {
                        Console.WriteLine("Skriv in ett tal, kan vara ett decimal tal.");
                    }
                    if (Längd <= 0)
                    {
                        Console.WriteLine("Skriv in din längd. Längd > 0!");
                    } 
                    
                        /*   Console.Write("Ange din längd i m:");
                   float Längd = float.Parse(Console.ReadLine());

                   Console.Write("Ange din vikt i kilo:");
                   float Vikt = float.Parse(Console.ReadLine());*/