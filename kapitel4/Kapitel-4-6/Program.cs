using System;

namespace Uppgift_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Munira";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(text[i]);
            }

        }
    }
}