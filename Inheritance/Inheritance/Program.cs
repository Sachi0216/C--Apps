using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate/ object
            Employee employee = new Employee();

            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
