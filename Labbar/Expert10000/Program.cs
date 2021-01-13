using System;

namespace Expert10000
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ange hur många timmar 
            Console.Write("Hur många timmar vill du träna per dag? ");

            //Läs in användarens svar
            string svar = Console.ReadLine();
            double timmarPerdag = 0;

            //double timmar = (double)svar; //omvandla till ett flyttal, 
            //kontrollera att användaren matar in ett tal
            
            while (!double.TryParse(svar, out timmarPerdag)&& timmarPerdag <= 0)
            {
                Console.Write("Oglitigt input,försök igen");
                svar =  Console.ReadLine();
            }

            //Räkna ut när man blir klar
            DateTime datumKlar = DateTime.Today.AddDays(10000 / timmarPerdag);
            TimeSpan hurLångTid = datumKlar - DateTime.Today;

            // Räkna ut antal år
            int antalÅr = hurLångTid.Days / 365;

            Console.WriteLine($"Du måste träna i {antalÅr} år, mao är du klar år {datumKlar}");
        }
    }
}
