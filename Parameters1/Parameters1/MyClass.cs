using System;
using System.Collections.Generic;
using System.Text;

namespace Parameters1
{
    public class MyClass
    {
        // default value is 2(will pass in with 
        public int Add(int data, int value = 2)
        {
            // set optional value
            
            return data + value;
        } 
    }
}
