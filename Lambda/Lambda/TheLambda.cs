using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int empID { get; set; }

        public Employee(int id, string fn, string ln)
        {
            empID = id;
            FirstName = fn;
            LastName = ln;
        }
    }
}
