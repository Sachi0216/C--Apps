using System;

namespace MoreOnClasses
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input decimal number:");
            Console.ReadLine();

            // instantiate class / method overloading
            Class1 class1 = new Class1();
            Class1 class2 = new Class1();

            int i = input;
            decimal j = input;

            class1.Sat(i);

            Console.ReadLine();

            class2.Sat(j);
            Console.ReadLine();


            // Static method and out parameters
            // Declaring variable
            // without assigning value
            int k;

            // Pass variable i to the method
            // using out 
            Addition(out k);

            // Displaying the value i
            Console.WriteLine("The addition of the value is: {0}", k);
        }

        // Method in which out parameter is passed
        // and this method returns the value of the passed param
        
        public static void Addition(out int k)
        {
            k = 30;
            k += k;
        }
    }
}
