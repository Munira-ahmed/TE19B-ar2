using System;

namespace exempel2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera 
            string val = "";


            //presentera en meny som visas tills användare stoppar
            while (val != "3")
            {
                Console.WriteLine("välj något av de följande val: ");
                Console.WriteLine("1. Addera: ");
                Console.WriteLine("2. multiplicera: ");
                Console.WriteLine("3.Stoppa program ");

                //läs in användarens input
                val = Console.ReadLine();
               
            
                //Om val = 1 
                if (val =="1")
                {
                    Console.WriteLine("Ange två tal efter varandra");
                double tal1 = double.Parse(Console.ReadLine());
                double tal2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"(tal1)+(tal2)="+ (tal1 +tal2));
                }
                //
                 if (val =="2")
                {
                    Console.WriteLine("Ange två tal efter varandra");
                double tal1 = double.Parse(Console.ReadLine());
                double tal2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"(tal1)*(tal2)="+ (tal1*tal2));
                }


                //3
                 if (val =="3")
                {
                    Console.WriteLine("Ange två tal efter varandra");
                double tal1 = double.Parse(Console.ReadLine());
                double tal2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"(tal1)+(tal2)="+ (tal1 +tal2));
                }
                
               switch (val?)
               {
                   case "1":
                Console.WriteLine("Ange två tal efter varandra");
                double tal1 = double.Parse(Console.ReadLine());
                double tal2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"(tal1)+(tal2)="+ (tal1 +tal2));

                   break;

                   default:
                   Console.WriteLine("välj mellan 1,2 och 3");
                   break;
               }

            }

        }
    }
}
