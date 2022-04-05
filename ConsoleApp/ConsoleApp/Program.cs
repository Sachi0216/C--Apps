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


            //string[] anime = { "One Piece", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };
            //Console.WriteLine("Please input some text");
            //string input = Convert.ToString(Console.ReadLine());


            //for (int j = 0; j < anime.Length; j++)
            //{
            //    anime[j] += input;
            //}
            //for (int j = 0; j < anime.Length; j++)
            //{
            //    Console.WriteLine(anime[j]);
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
            //List<string> shonen = new List<string>() { "One Piece", "Naruto", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };
            //Console.WriteLine("Please input text to search in the list:");
            //string input = Console.ReadLine();
            //Console.WriteLine("You have ");

            //for (int i = 0; i < shonen.Count; i++)
            //{
            //    if (input == shonen[i])
            //    {
            //        Console.WriteLine(i + " " + shonen[i]);

            //    }
            //}
            //int foundAt = -1;
            //for (int i = 0; i < shonen.Count; i++)
            //{
            //    string lookingAt = shonen[i];
            //    if(lookingAt == input)
            //    {
            //        foundAt = -1;
            //        break;
            //    }
            //    if (foundAt == -1)
            //        Console.WriteLine("The list doesn't have the anime you're looking for");
            //    else
            //        Console.WriteLine("The anime you're looking for is in list index" +foundAt + shonen);
            //}
            //Console.ReadLine();
            //Console.WriteLine("Please input text to search in the list: ");
            //string userItem = Console.ReadLine();
            //Console.WriteLine("You have " + userItem);
            //Console.WriteLine(names.IndexOf(userItem));


            // part 5
            //List<string> anShows = new List<string>() { "One Piece", "Naruto", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };
            //Console.WriteLine("Enter one of the following anime shows:\nMy Hero Acadamia, \nNaruto, \nSeven Deadly Sins\n");
            //string input = Console.ReadLine();

            //bool matchExists = false;

            //for (int i = 0; i < anShows.Count; i++)
            //{
            //    if (anShows[i] == input)
            //    {
            //        matchExists = true;
            //        Console.WriteLine(i);
            //    }
            //}

            //if (matchExists == false)
            //{
            //    Console.WriteLine("Sorry, this is not in the list");
            //}



            // part 6
            List<string> names = new List<string>() { "One Piece", "Naruto", "Seven Deadly Sins", "Naruto", "My Hero Acadamia" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();


        }
    }
}
