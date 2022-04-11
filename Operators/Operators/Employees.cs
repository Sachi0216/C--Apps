using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    public class Employees
    {
        // overloading operator to see if two employee objects are equal
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        // if equal to == 
        public static bool operator ==(Employees employee1, Employees employee2)
        {
            // checking by employee id
            return employee1.Id == employee2.Id;
        }
        // returning false !=
        public static bool operator !=(Employees employee1, Employees employee2)
        {
            return employee1.Id != employee2.Id;

        }
    }
}
