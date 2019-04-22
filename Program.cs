using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.Combine(RootPath(), "files"), "ListOfNames.txt");
            string[] lines = File.ReadAllLines(path);

            Console.WriteLine("\n");
            Console.WriteLine("=========================================");
            Console.WriteLine("\t # List Unsort Names #");
            Console.WriteLine("=========================================");
            Console.WriteLine("\n");

            foreach (string line in lines)
            {
                Console.WriteLine("\t " + line);
            }

            Console.WriteLine("\n");
            Console.WriteLine("=========================================");
            Console.WriteLine("\t # List Sort Names #");
            Console.WriteLine("=========================================");
            Console.WriteLine("\n");

            List<ListOfNames> lists = new List<ListOfNames>();
            foreach (string line in lines)
            {
                ListOfNames mdl = new ListOfNames();
                {
                    mdl.Name = line;
                }
                lists.Add(mdl);
            }
            foreach (var val in lists.OrderBy(x => x.Name.Substring(x.Name.LastIndexOf(' ') + 1)))
            {
                Console.WriteLine("\t " + val.Name);
            }

            Console.WriteLine("\n");
            Console.WriteLine("=========================================");
            Console.WriteLine("\t Press any key to exit");
            Console.WriteLine("=========================================");
            Console.ReadKey();
        }

        protected static string RootPath()
        {
            return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        }

    }
}
