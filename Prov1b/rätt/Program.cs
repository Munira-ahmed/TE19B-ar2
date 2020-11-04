using System;

namespace lön
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Det här programmet ska ränka ut din Nettolön.");

            // Loopen
            string igen = "j";
            while (igen == "j")
            {
                // upprepa om användaren matar in bruttolön < 0
                int bruttolön = 0;
                while (bruttolön <= 0)
                {
                    Console.WriteLine("Hur mycket tjänar du innan skatt i kr?");
                    string bruttolönString = Console.ReadLine();

                    //bruttolön = int.Parse(bruttolönString);
                    bool flaggaLön = int.TryParse(bruttolönString, out bruttolön);

                    //varna användaren om  fel inmatning
                    if (flaggaLön == false)
                    {
                        Console.WriteLine("Mata in ett heltal");
                    }
                    
                        //om bruttolön < 0 skriv ut felmedelande
                        else if (bruttolön <= 0)
                        {
                            Console.WriteLine("Bruttolön måste vara > 0 kr");
                        }
                    
                }

                int marginalskatt;


                if (bruttolön < 10000)
                {
                    marginalskatt = 8;

                }

                else if (bruttolön < 145000)
                {
                    marginalskatt = 22;

                }
                else if (bruttolön < 5150000)
                {
                    marginalskatt = 33;

                }
                else
                {
                    marginalskatt = 53;


                }
                int nettolön = bruttolön * (100 - marginalskatt) / 100;

                Console.WriteLine($"Din nettolön blir {nettolön} kr"
            + $"uräkning baserad på bruttolönen {bruttolön} i kr och marginalskatten {marginalskatt} ");

                Console.WriteLine("Vill du göra en ny beräkning(j/n)");
                igen = Console.ReadLine();

                //acceptera svar även om användaren skriver med versaler
                igen = igen.ToLower();

            }
        }

    }
}