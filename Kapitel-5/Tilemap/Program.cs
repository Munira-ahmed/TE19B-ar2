using System;

namespace Tilemap
{
    class Program
    {
        static void Main(string[] args)
        {
            // skapa en labyrint 
            // int[,] = två dimentionel array
            int[,] labyrint = new int[10,10]  { //new int[5,5] 
                 {1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                 {2, 0, 0, 0, 1, 1, 1, 1, 0, 1},
                 {1, 0, 1, 0, 1, 1, 1, 0, 1, 1},
                 {1, 0, 1, 0, 0, 0, 0, 0, 1, 1},
                 {1, 0, 1, 1, 0, 1, 1, 0, 1, 1},
                 {1, 0, 1, 1, 0, 1, 1, 0, 1, 1},
                 {1, 0, 1, 1, 0, 1, 1, 0, 1, 1},
                 {1, 0, 0, 0, 0, 1, 1, 0, 0, 2},
                 {1, 0, 1, 1, 1, 1, 1, 1, 1, 1},
                 {1, 0, 1, 1, 1, 1, 1, 1, 1, 1}
            };
           Console.OutputEncoding = System.Text.Encoding.Default;
           //loopa igenom raderna 
           for (int y = 0; y < 10; y++)
           {
               //loopa genom cellerna  0 - 4
               for (int x = 0; x < 10; x++)
               {
                  //om 1 skriv ut vit fyrkant, annars svart fyrkant
                  if (labyrint[y,x]== 1)
                  {
                      Console.Write('\u2B1C');
                  }
                  else if (labyrint[y,x]==2)
                  {
                      Console.Write('\u2B9A');
                  } else
                  {
                       Console.Write('\u2B1B');
                  }
               }
            //ny rad
             Console.WriteLine();
           }
        }
    }
}
