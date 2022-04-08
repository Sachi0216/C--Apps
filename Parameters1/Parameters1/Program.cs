using System;

namespace Parameters1
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
               
            Console.WriteLine("Please input two numbers\n Input numbber one");
            int number = Convert.ToInt32(Console.ReadLine());
            // creating var for user input and converting to int
            Console.WriteLine("Input second number: This one is optional");
            // Keyword optional(create if/else to verify if second number was given)
            string numberStr = Console.ReadLine();

            MyClass myclass = new MyClass();
           // taking string var and checking if its empty, if so no var was entered and will pass default value set in class
           // setting numberStr to empty str with ""
            if (numberStr == "")
            {
              
                int i = myclass.Add(number);
                Console.WriteLine(i);
            }
            else
            {
                int j = Convert.ToInt32(numberStr);
                int result = myclass.Add(number, j);
                Console.WriteLine(result);
            }
                // if they didnt enter a second number 
                // Call method with one paremeter
                // else call method with two parameters


         
            Console.ReadLine();

        }
        
    }
    
}
