using System;

namespace Omprov_1d
{
    class Program
    {
        static void Main(string[] args)
        {
            //Först en kort presentation om programmet
            Console.WriteLine("Det här programmet räknar ut din BMI, dvs Body Mass Index.");

            //Loop
            string igen = "j";
            while (igen == "j")
            {
                //Användaren ska mata in Vikt och Längd
                //Fel input hanteras av while looparna 
                float Längd = 0;
                while (Längd <= 0)
                {
                    Console.Write("Ange din längd i m:");
                    string stringLängd = Console.ReadLine();
                    bool flaggaLängd = float.TryParse(stringLängd, out Längd);

                    //Om tryParse inte funkar.
                    if (flaggaLängd == false)
                    {
                        Console.WriteLine("Skriv in din  längd i decimaltal eller heltal!");
                    }

                    //Om användaren skriver in något mindre än 0
                    if (Längd <= 0)
                    {
                        Console.WriteLine("Din längd måste vara mer än 0 meter!");
                    }

                }

                //felmeddelanden gällande användarens input här med
                float Vikt = 0;
                while (Vikt <= 0)
                {
                    Console.Write("Ange din Vikt i kilo:");
                    string stringVikt = Console.ReadLine();
                    bool flaggaVikt = float.TryParse(stringVikt, out Vikt);

                    if (flaggaVikt == false)
                    {
                        Console.WriteLine("Skriv in din Vikt i decimaltal eller heltal!");
                    }
                    if (Vikt <= 0)
                    {
                        Console.WriteLine("Din Vikt måste vara mer än 0 kilo!");
                    }
                }

                // Räkna ut BMI 
                float BMI = Vikt / (Längd * Längd);

                //if , else if och else. BMI och förklaring.
                if (BMI < 16.00)
                {
                    Console.WriteLine("Du är kraftigt underviktig!");
                }

                else if (BMI < 16.99)
                {
                    Console.WriteLine("Du är underviktig");
                }
                else if (BMI < 18.49)
                {
                    Console.WriteLine("Du kan vara lite underviktig");
                }
                else if (BMI < 24.99)
                {
                    Console.WriteLine("Du har en normal BMI");
                }
                else if (BMI < 27.49)
                {
                    Console.WriteLine("Du kan vara lite överviktig");
                }
                else if (BMI < 29.99)
                {
                    Console.WriteLine("Du är överviktig");
                }
                else if (BMI < 34.99)
                {
                    Console.WriteLine("Du är överviktig, fetma klass 1");
                }
                else if (BMI < 39.99)
                {
                    Console.WriteLine("Du är överviktig, fetma klass 2");
                }
                else 
                {
                    Console.WriteLine("Du har sjuklig fetma");
                }

                //Fråga om användaren vill göra en till beräkning
                Console.WriteLine("Vill du göra en ny beräkning? (j/n)");
                igen = Console.ReadLine().ToLower();
            }
        }
    }
}
