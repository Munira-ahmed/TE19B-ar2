using System;

namespace Boye
{
    class Program
    {
        static void Main(string[] args)
        {
            //lagra en dikt i en array
            string[] dikt = {
             "Den mätta dagen, den är aldrig störst.",
             "Den bästa dagen är en dag av törst.",
             "Nog finns det mål och mening i vår färd -",
             "men det är vägen, som är mödan värd.",
             "Det bästa målet är en nattlång rast,",
             "där elden tänds och brödet bryts i hast.",
             "På ställen, där man sover blott en gång",
             "blir sömnen trygg och drömmen full av sång.",
             "Bryt upp, bryt upp! Den nya dagen gryr.",
             "Oändligt är vårt stora äventyr.",
            };

            //skriv ut dikten
            //Loopa igenom arrayen
           /* foreach (var rad in dikt)
            {
                Console.WriteLine(rad);
            }*/
           
                
            int totalAntalOrd = 0;
            for (int i = 0; i < dikt.Length; i++)
            {
                if (i % 2 == 0)
                {
                    //skriv ut raden
                    Console.WriteLine(dikt[i]);
                }
                else
                {
                    //skriv ut raden + en tom rad
                    Console.WriteLine(dikt[i]+ "\n");
                }
                //dela upp raden i ord
                string[] orden = dikt[i].Split(' ');
                //räkna orden: antal ord i arrayen
                int antalOrd = orden.Length;
           
               //Addera till total antal ord 
               totalAntalOrd += antalOrd;

              
            }
             // Antal ord i dikten
               Console.WriteLine($"Antal ord i dikten är {totalAntalOrd}");
        }
    }
}
