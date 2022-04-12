using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of at least 10 employees
            List<string> Employees = new List<string>(); // { "James Doe", "Martin Lawrence", "Sam Jones", "Rad Richy", "Max Pane", "Charles Barkley", "Harry Potter", "Thomas Jefferson", "Joe Mo", "Joe Tang" };
            
            
            Employees.Add("James Doe");
            Employees.Add("Martin Lawrence");
            Employees.Add("Sam Jones");
            Employees.Add("Rad Richy");
            Employees.Add("Max Pane");
            Employees.Add("Charles Barkley");
            Employees.Add("Harry Potter");
            Employees.Add("Thomas Jefferson");
            Employees.Add("Joe Mo");
            Employees.Add("Joe Tang");


            //Foreach loop

            foreach (string employees in Employees)
            {
                Console.WriteLine(employees);
                Console.WriteLine(employees.Contains("Joe"));
                Console.ReadLine();

            }

        }
    }
}
