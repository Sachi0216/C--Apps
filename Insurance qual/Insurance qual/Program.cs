using System;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            // boolean set up for approval
            int age = 15, speed = 3;
            bool DUI = false;

            Console.WriteLine("Welcome to Insurance approval! Answer a few short questions to better assist us.");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?\nPlease enter true or false");
            DUI = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("How many speeding tickets  have you had?");
            speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            // bool 
            Console.WriteLine(age > 15 && speed <= 3 && !DUI);

            Console.ReadLine();

        }
    }
}