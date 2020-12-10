using System;

namespace Tilemap
{
    class Program
    {
        static void Main(string[] args)
        {
            // skapa en labyrint 
            // int[,] betyder att den är två dimentionel
            // kan skrivas utan new int[5,5]- kompilatorn kan översätta och förstå- 
            int[,] labyrint = { //new int[5,5] 
                 {1, 1, 1, 1, 1},
                 {0, 0, 0, 0, 1},
                 {1, 0, 1, 0, 1},
                 {1, 0, 1, 0, 0},
                 {1, 0, 1, 1, 1}
            };
           
        }
    }
}
