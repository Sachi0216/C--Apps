using System;

namespace Strings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {// exception handling
            try
            {
                int[] numbersDiv = { 10, 12, 20, 30, 50, 100 };
                Console.WriteLine("Pick a number to divide by.");
                int input = Convert.ToInt32(Console.ReadLine());

                for(int i = 0; i < 6; i++)
                {
                    Console.WriteLine(numbersDiv[i] / input);
                }
                
                //Console.WriteLine("Dividing the two...");
                //int numberThree = numberOne / numberTwo;
                //Console.WriteLine(numberOne + " divided by" + numberTwo + " equals" + numberThree);
                //Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero.");
            }// general exception in case something is done that isnt a format or divide by zero
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // End of program
            Console.WriteLine("Thank you for participating");
            Console.ReadLine();
        }
    }
}
