using System;

namespace CallingParam
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            // instantiate class
            SubAssign subAssign = new SubAssign();

            // call method in the class passing two ints

            int i = 3;
            int j = 4;
            subAssign.Intap(i, j);

            subAssign.Intap(num1: 2, num2: 4);

            Console.ReadLine();
        }
    }
    
}
