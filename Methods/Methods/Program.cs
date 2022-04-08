using System;

namespace Methods
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {// main
            Methods methods = new Methods();
            Methods methods2 = new Methods();
            Methods methods3 = new Methods();
            
            

            
            int result = methods.Add(2);
            Console.WriteLine(result);

            result = methods2.Add(2.2m);
            Console.WriteLine(result);
            //int result3 = methods.Divide(result, 1);

            result = methods3.Add("2");
            Console.WriteLine(result);
            
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
// methods have to be part of a class