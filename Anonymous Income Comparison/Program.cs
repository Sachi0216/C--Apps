using System;

namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // person 1 information
            Console.WriteLine("Person 1 Salary information");
            Console.ReadLine();

            Console.WriteLine("What is your hourly rate?");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int weeklyHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1:");
            int product = hourlyRate * weeklyHours * 52;
            Console.WriteLine(product);

            // Person 2 information

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly pay?");
            int p2hourlyRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int p2weeklyHours = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Annual Salary of Person 2:");
            int salary = p2hourlyRate * p2weeklyHours * 52;
            Console.WriteLine(salary);

            // Comaparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();

            bool trueOrFalse = product > salary;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();


        }
    }
}
