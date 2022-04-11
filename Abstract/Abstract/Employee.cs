using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    // inheriting from person class/ interface 
    // 
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine(" interface.");
        }
    }
}
