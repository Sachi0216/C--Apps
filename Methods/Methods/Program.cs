using System;

namespace Methods
{
    class Program
    {
        public int Data { get; set; }
        static void Main(string[] args)
        {// main
            Console.WriteLine("Enter input:");
            var userValue = Convert.ToInt32(Console.ReadLine());

            var operatorObject = new Methods();
            var result = operatorObject.Add(userValue, 4);
            result = operatorObject.Subtract(result, 3);
            result = operatorObject.Divide(result, 1);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
// methods have to be part of a class