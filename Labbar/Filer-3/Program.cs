using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace Filer_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //de först 8 minuterna i "C# Data Access: Text Files"
            string filePath = @"C:\github\TE19B-ar2\test.txt";
            /* List<string> lines = File.ReadAllLines(filePath).ToList();

             foreach (var line in lines)
             {
                Console.WriteLine(line);
             }

             lines.Add("hello world");
             File.WriteAllLines(filePath,lines);*/

          
          
          
          
          // Andra delen funkar inte
           /* List<person> people = new List<person>();

            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                newPerson.Firstname = entries[0];
                newPerson.Lastname = entries[1];
                newPerson.Url = entries[2];

                people.Add(newPerson);
            }
            foreach (var person in people)
            {
                Console.WriteLine($"{ person.Firstname} {person.Lastname}: {person.Url}");
            }*/
        }
   }   }
