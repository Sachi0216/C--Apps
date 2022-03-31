using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        Console.WriteLine("Please select an index of the array.");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(numArray[number]);


        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };


        // String array
        string[] textArray = new string[] { "Sith", "Force", "Jedi", "Droid", "Mandalorian" };

        Console.WriteLine("Please select a index of the array");
        int input = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(textArray[input]);

        // String list
        List<string> StringList = new List <string>();
        StringList.Add("Anakin");
        StringList.Add("Luke");
        StringList.Add("Jar-Jar");
        StringList.Add("Obi-Wan");

        Console.WriteLine("Please select an index to the list");
        int response = Convert.ToInt32(Console.ReadLine());
        //for selecting an index of the array i'm requiring trhe user to input a number or "int"
        // being able to select any indexes from the array i input response.
        Console.WriteLine(StringList[response]);
        Console.ReadLine();




    }
}

