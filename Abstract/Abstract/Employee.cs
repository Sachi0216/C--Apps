using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    // inheriting from person class
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        
    }
}
