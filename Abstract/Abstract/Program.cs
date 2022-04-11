using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // instatiate/ obj
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();

            
            IQuittable quit = new Employee();
            // calling quit method
            quit.Quit();

            Console.ReadLine();
        }
    }
}
