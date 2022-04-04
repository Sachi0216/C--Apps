using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //    for (int i = 0; i < testScores.Length; i++)
            //    {
            //        if (testScores[i] > 85)
            //        {
            //            Console.WriteLine("Passing test score: " + testScores[i]);
            //        }
            //    }
            //    Console.ReadLine();


            //string[] names = { "One Piece", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };
            //Console.WriteLine("Please input some text");
            //string input = Convert.ToString(Console.ReadLine());


            //for (int j = 0; j < names.Length; j++)
            //{
            //    names[j] += input;
            //}
            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();


            //// part two infinite loop program

            //Console.WriteLine("Guess a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = number == 12;

            //do
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed 12. This is correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!isGuessed);


            // part three loop

            //int[] testscores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testscores.Length; i++)
            //{
            //    if (testscores[i] > 85)
            //    {
            //        Console.WriteLine("passing test score: " + testscores[i]);
            //    }
            //    if (testscores[i] <= 80)
            //    {
            //        Console.WriteLine("You did not pass: " + testscores[i]);
            //    }
            //}
            //Console.ReadLine();


            // part 4 list of strings
            List<string> names = new List<string>() { "One Piece", "Naruto", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };
            Console.WriteLine("Please input text to search in the list:");
            string input = Console.ReadLine();
            Console.WriteLine("You have ");

            for(int i = 0; 0 < names.Count; i++)
            {
               if(input== names[i])
                {
                    Console.WriteLine(i + " " + names[i]);
                    
                }
            }
            Console.ReadLine();
            //Console.WriteLine("Please input text to search in the list: ");
            //string userItem = Console.ReadLine();
            //Console.WriteLine("You have " + userItem);
            //Console.WriteLine(names.IndexOf(userItem));



            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(96);
            //testScores.Add(94);
            //testScores.Add(92);
            //testScores.Add(89);


            //foreach (int score in testScores)
            //{
            //    if (score > 95)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //}
            //Console.ReadLine();

            // part 6
            //List<string> names = new List<string>() { "One Piece", "Naruto", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>() { 90, 99, 74, 23, 99 };
            //List<int> passingScore = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScore.Add(score);
            //    }
            //}
            //Console.WriteLine(passingScore.Count);
            //Console.ReadLine();
        }
    }
}
