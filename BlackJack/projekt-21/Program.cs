using System;

namespace projekt_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv välkomstmeddelande
            Console.WriteLine("VÄlkommen till 21:an!");

            // deklarera menyVal   
            string menyVal = "0";

            // while (menyval != ”4”)
            while (menyVal != "4")
            {
                // Skriv ut meny
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programmet");
                // Läs in menyVal
                menyVal = Console.ReadLine();

                // switch menyVal
                switch (menyVal)
                {
                    case "1":
                        //"spela en omgång av 21:an!"
                        break;

                    case "2":
                        //Console.WriteLine("Visa senaste vinnaren");
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
