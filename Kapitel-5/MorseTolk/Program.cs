using System;

namespace MorseTolk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berätta om programmets 
            Console.WriteLine("Detta program ska tolka bokstäver till morsekod");
            //Be om ett meddelande 
            Console.Write("Ange ett meddelande:");
            string meddelande = Console.ReadLine().ToUpper();

            //Översätt bokstav till morsekod
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
            //skapa en samling för morsekoden (Array)
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };
            string morseMeddelande = "";
            //Loopa igenom meddelandet 
            for (int i = 0; i < meddelande.Length; i++)
            {
                //skriv ut varje tecken 
                string bokstav = meddelande[i].ToString();

                // Hitta bokstavens plats i alfabetet 
                int index = alfabetet.IndexOf(bokstav);

                // Skriv ut morsekoden för bokstaven 

                string morseBokstav = morse[index];
                Console.WriteLine($"{bokstav}'s morsekod är{morseBokstav}");

                //samla in hela meddelandet i morsekod
                morseMeddelande += morseBokstav;
            }
             Console.WriteLine($"Hela meddelandet är: {morseMeddelande}");
        }
    }
}
