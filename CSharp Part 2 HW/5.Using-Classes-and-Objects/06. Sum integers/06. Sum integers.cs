using System;

class SumIntegers
{
    //	You are given a sequence of positive integer values written into a string, separated by spaces.
    //	Write a function that reads these values from given string and calculates their sum.

    static void Main()
    {
        Console.Write("Enter a sequence of positive integers written into a string, separated by spaces: ");
        string[] str = Console.ReadLine().Split(' ');
        int sum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            sum = sum + int.Parse(str[i].Trim());
        }
        Console.WriteLine("The sum of these numbers is: {0}", sum);
    }
}

