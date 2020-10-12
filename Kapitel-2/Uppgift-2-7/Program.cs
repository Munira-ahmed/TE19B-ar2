using System;

namespace Uppgift_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Det här är bara något jag kopierade för att testa :)
            
            Console.WriteLine("Vänligen skriv in ditt förnamn och efternamn");
            string helaNamnet = Console.ReadLine();

            // Hitta mellanslaget i namnet
            int indexFörMellanslag = helaNamnet.IndexOf(" ");

            // Ta reda på förnamn och efternamn
            string förnamn = helaNamnet.Substring(0, indexFörMellanslag);
            string efternamn = helaNamnet.Substring(indexFörMellanslag + 1);

            Console.WriteLine("Ditt förnamn är " + förnamn + ".");
            Console.WriteLine("Ditt efternamn är " + efternamn + ".");
        }
    }
}
