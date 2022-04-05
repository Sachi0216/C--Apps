using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }
            Console.ReadLine();


            string[] anime = { "One Piece", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };
            Console.WriteLine("Please input some text");
            string input = Convert.ToString(Console.ReadLine());


            for (int j = 0; j < anime.Length; j++)
            {
                anime[j] += input;
            }
            for (int j = 0; j < anime.Length; j++)
            {
                Console.WriteLine(anime[j]);
            }
            Console.ReadLine();


            // part two infinite loop program

            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

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
            while (!isGuessed);



            //// part three
            int[] testscores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            for (int i = 0; i < testscores.Length; i++)
            {
                if (testscores[i] > 85)
                {
                    Console.WriteLine("passing test score: " + testscores[i]);
                }
            }
            for (int i = 0; i <= testscores.Length; i++)
            {
                if (testscores[i] <= 80)
                {
                    Console.WriteLine("You did not pass: " + testscores[i]);
                }
            }
            Console.ReadLine();


            // part four
            List<string> shonen = new List<string>() { "One Piece", "Naruto", "Seven Deadly Sins", "My Hero Acadamia" };
            Console.WriteLine("Please input text to search in the list:");
            string input1 = Console.ReadLine();
            Console.WriteLine("You have ");

            bool found = false;

            for (int i = 0; i < shonen.Count; i++)
            {
                if (input1 == shonen[i])
                {
                    Console.WriteLine(i + " " + shonen[i]);
                    found = true;
                    break;
                }
            }
            // flag, take action if its not found.
            if (!found)
            {
                Console.WriteLine("Item not found on list");

            }
            // notes on not what to do
            //int foundAt = -1;
            //for (int i = 0; i < shonen.Count; i++)
            //{
            //    string lookingAt = shonen[i];
            //    if (lookingAt == input1)
            //    {
            //        foundAt = -1;
            //        break;
            //    }
            //    if (foundAt == -1)
            //        Console.WriteLine("The list doesn't have the anime you're looking for");
            //    else
            //        Console.WriteLine("The anime you're looking for is in list index" + foundAt + shonen);
            //}
            //Console.ReadLine();
            //Console.WriteLine("Please input text to search in the list: ");
            //string userItem = Console.ReadLine();
            //Console.WriteLine("You have " + userItem);
            //Console.WriteLine(names.IndexOf(userItem));


            // part 5
            List<string> anShows = new List<string>() { "One Piece", "Naruto", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };
            Console.WriteLine("Enter one of the following anime shows:\nMy Hero Acadamia, \nNaruto, \nSeven Deadly Sins\n");
            string input2 = Console.ReadLine();

            bool matchExists = false;

            for (int i = 0; i < anShows.Count; i++)
            {
                if (anShows[i] == input2)
                {
                    matchExists = true;
                    Console.WriteLine(i);
                }
            }

            if (matchExists == false)
            {
                Console.WriteLine("Sorry, this is not in the list");
            }



            // part 6
            List<string> names = new List<string>() { "One Piece", "Naruto", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };
            List<string> empty = new List<string>();

                        // foreach(string name in names)
                        //{
                        // if (empty.Container(name))
                        //     Console.WriteLine("{0} has already been seen", name);
                        // else
                        // {
                        //    empty.Add(name);
                        //    Console.WriteLine("{0} has not been seen", name);
                        // }
                        //}

                        // Console.ReadLine();

            foreach (string name in names)
            {
                bool checker = false;
                foreach (string item in empty)
                {
                    if (name == item)
                    {
                        checker = true;
                    }
                }
                if (checker == false)
                {
                    Console.WriteLine(name);
                    empty.Add(name);
                }
                else
                {
                    Console.WriteLine(name + " Has already appreared");
                }
            }

            Console.ReadLine();


        }
    }
    
}
