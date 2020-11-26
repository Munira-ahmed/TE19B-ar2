using System;

namespace HittaBokstav
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ange en bokstav
            Console.Write("Ange en bokstav:");
            string bokstav = Console.ReadLine().ToUpper();

            // För säkerhets skull omvandla till versaler 
            //bokstav = bokstav.ToUpper();

            //skapa en samling för alfabetet (string)
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

            // Hitta bokstavens plats i alfabetet 
            int index = alfabetet.IndexOf(bokstav);

            //Vart fanns bokstaven
            Console.WriteLine($"{bokstav} finns på position {index} och på morsekod är det");

            //skapa en samling för morsekoden (Array)
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };

            // Skriv ut morsekoden för bokstaven 

            string morseBokstav = morse[index];
            Console.WriteLine($"{bokstav}'s morsekod är{morseBokstav}");
            
        }
    }
}
