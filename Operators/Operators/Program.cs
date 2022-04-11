using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiate
            Employees employee1 = new Employees();
            Employees employee2 = new Employees();
            // giving same first and last name since method called for employee id however
            
            employee1.Firstname = "Eli";
            employee1.Lastname = "Davis";
            employee2.Firstname = "Eli";
            employee2.Lastname = "Davis";
            // what i'm checking for, equal or not equal employee id
            employee1.Id = 44;
            employee2.Id = 42;
            Console.WriteLine("Does employee1 and employee2 have the same first names? " + (employee1.Firstname == employee2.Firstname));
            Console.WriteLine("Does employee1 and employee2 have same last names? " + (employee1.Lastname == employee2.Lastname));
            // overloaded == operator to take in two employee obj's and returned if thoe are equal by comparing id's inside the method. 
            Console.WriteLine((employee1 == employee2));
        }
    }
}
