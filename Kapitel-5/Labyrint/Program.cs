using System;

namespace Labyrint
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en labyrint
            int[,] labyrint = {
                 {1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                 {0, 0, 0, 0, 1, 1, 1, 1, 0, 1},
                 {1, 0, 1, 0, 1, 1, 1, 0, 1, 1},
                 {1, 0, 1, 0, 0, 0, 0, 0, 1, 1},
                 {1, 0, 1, 1, 0, 1, 1, 0, 1, 1},
                 {1, 0, 1, 1, 0, 1, 1, 0, 1, 1},
                 {1, 0, 1, 1, 0, 1, 1, 0, 1, 1},
                 {1, 0, 0, 0, 0, 1, 1, 0, 0, 1},
                 {1, 0, 1, 1, 1, 1, 1, 1, 1, 1},
                 {1, 0, 1, 1, 1, 1, 1, 1, 1, 1}
            };

            // Slumpa fram in en figur i labyrinten
            Random slumpMotor = new Random();
            while (true)
            {
                // Slumpa fram koordinater
                int x = slumpMotor.Next(0, 10);  
                int y = slumpMotor.Next(0, 10);  

                // Hamnar vi i en gång
                if (labyrint[y, x] == 0)
                {
                    labyrint[y, x] = 2;
                    break;
                }
            }

           Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Skriva ut labyrinten
            // Loopa igenom rad för rad, dvs i y-led
            for (int y = 0; y < 10; y++)
            {
                // Loopa igenom kolumnvis, dvs x-led
                for (int x = 0; x < 10; x++)
                {
                    switch (labyrint[y, x])
                    {
                        case 1: // En vägg
                        Console.Write('\u2B1C');
                        break;

                        case 2: // En figur
                        Console.Write("");
                        break;

                        default: // En gång
                        Console.Write('\u2B1B');
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}