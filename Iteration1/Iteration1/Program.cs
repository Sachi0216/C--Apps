using System;
using System.Collections.Generic;

namespace Iteration1
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


            string[] names = { "One Piece", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };
            Console.WriteLine("Please input some text");
            string input = Convert.ToString(Console.ReadLine());

            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j]);
            }
            Console.ReadLine();

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


            //List<string> names = new List<string>() { "One Piece", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };

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
