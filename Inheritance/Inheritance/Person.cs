using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Person
    {
        // properties with string data type
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {

            Console.WriteLine("Name:" + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
