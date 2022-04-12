using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instatiate with string type
            Employees<string> things1 = new Employees<string>();
            // List of strings
            things1.Things = new List<string>() { "Jedi", "Mandalorian", "Sith" };
            // int instatiation
            Employees<int> things2 = new Employees<int>();
            // List of intehers
            things2.Things = new List<int>() { 1, 2, 3, 4 };

            // loop that prints all of the "things" 
            foreach (string items1 in things1.Things)
            {
                Console.WriteLine(items1);
            }

            foreach (int items2 in things2.Things)
            {
                Console.WriteLine(items2);
            }
            Console.ReadLine();
        }
    }
}
