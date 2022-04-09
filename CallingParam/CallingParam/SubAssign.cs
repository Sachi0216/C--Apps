using System;
using System.Collections.Generic;
using System.Text;

namespace CallingParam
{
    class SubAssign
    {
        // method that takes in two integers as param
        // using void method(no return )
        public void Intap( int num1, int num2)
        {
            // math op on first parameter
            int result = num1 + 5;
            num2 = 3;
            Console.WriteLine(num2);
        }
    }
}
