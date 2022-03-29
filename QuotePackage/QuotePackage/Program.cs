using System;

namespace QuotePackage
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Error: Package too heavy to be shipped via Package express, Have a good day.");
            }
            else
            {//package dimensions 
                Console.WriteLine("Please enter package height");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package length");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package width");
                int width = Convert.ToInt32(Console.ReadLine());

                if (height + length + width > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");

                }
                else
                { // displaying package total
                    double product = height * length * width;
                    Console.WriteLine(product);

                    double total = product * packageWeight / 100 ;
                    Console.WriteLine(total);

                    Console.WriteLine("Your estimated total for shipping this package is: $"+ total);


                }
            }
        }
    }
}
