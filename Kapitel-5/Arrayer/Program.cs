using System;

namespace Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array är en samling av element

            //Alt 1: Här skapar vi en array på 3 strings
            //skapa en array av ttre städers namn: "stockholm", "paris", "london"
            string[] städer = {"stockholm", "paris", "london"};
            //skriv ut innehållet
            //städer[0] = "stockholm";
            //städer[1] = "paris";
            //städer[2] = "london";

            //Alt 2: skapa en tom array på 2 strins
            string [] länder = new string[2];

            // skapa en annan array av tal
            int[] årtal = new int[3];

            //fylla en array
            länder[0] = "frankrike";
            länder[1] = "polen";

            årtal[0] = 1945;
            årtal[1] = 1800;
            årtal[2] = 1545;

            //skriv ut alla årtalen i arrayen årtal
            for (int i = 0; i < årtal.Length; i++) //om jag skriver i<3 blir det för hårdkodat så man skriver årtal.length istället
            {
                Console.Write(årtal[i]); // årtal[0], årtal[1], årtal[2]
            }

        }
    }
}
