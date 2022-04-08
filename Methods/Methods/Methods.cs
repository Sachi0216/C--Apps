using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Methods
    {
        public int Add(int Value)
        {

            return Value + 4;
        }

        public int Add(decimal Value)
        {
            return Convert.ToInt32(Value - 0.2m);
        }
        // type infront of method that determines type returned
        public int Add(string data)
        {
            // Converting string to int (declare type of integer before variable)
            // keyword int infront of the variable declares what it is// // type which is integer
            int newInt = Convert.ToInt32(data); 
            
            return Convert.ToInt32(newInt * 3); 
        
        }
    } // all methods returning an integer
}
