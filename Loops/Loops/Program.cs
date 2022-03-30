using System;

namespace Loops
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Guess a number?");
                int number = Convert.ToInt32(Console.ReadLine());
                bool isGuessed = number == 12;
                // if the guessed number is hit then the program stops without running through the loop, do while is how the program can be ran at least once
                // do while loop, (code from while statement) do while allows for loop to at least be ran through once.
                do
                {
                    switch (number)
                    {
                        case 62:
                            Console.WriteLine("You guessed 62. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 29:
                            Console.WriteLine("You guessed 29. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 55:
                            Console.WriteLine("You guessed 55. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 12:
                            Console.WriteLine("You guessed 12. This is correct!");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("You are wrong.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                // While statement (code rep)
                while (!isGuessed);
                    switch (number)
                    {
                        case 62:
                            Console.WriteLine("You guessed 62. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 29:
                            Console.WriteLine("You guessed 29. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 55:
                            Console.WriteLine("You guessed 55. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 12:
                            Console.WriteLine("You guessed 12. This is correct!");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("You are wrong.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }

            Console.Read();
            }
        }
 }
