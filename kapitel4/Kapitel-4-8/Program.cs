using System;

namespace Kapitel_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett tal: ");

            //input
            string input = Console.ReadLine();

            //räkna fram längden på svaret
            int längd = input.Length;
            //Console.WriteLine($"längden på talet är {längd}");

            //loopa igenom talet
            //från första till sista tecken 
            int antal = 0;
            for (int i = 0; i < längd; i++) //hiss 
            {
                Console.WriteLine($"index ={i}, tecknet: {input[i]}"); //input = hus,  index= våning

                //för varje siffra: är det 3 eller 7? input[i] = tecken inte bara input
                if (input[i] == '3' || input[i] == '7') // man skriver '' istället för "" när det är char
                {
                    // vi måste deklarera variabeln antal  innan for-loopen . tex. antecknings papper ges innan precessen så att personen kan komma ihåg och anteckna under processen. 
                    antal++;
                }
            }
            //svaret: finns en 3:a eller en 7:a i talet?
            if (antal > 0)
            {
                Console.WriteLine("Hurra! Det finns en 3:a eller en 7:a");
            }
            else
            {
                Console.WriteLine("talet har ingen 3:a eller 7:a");
            }

        }
    }
}
