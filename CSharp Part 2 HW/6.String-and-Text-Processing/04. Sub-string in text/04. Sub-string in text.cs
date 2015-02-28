using System;
using System.Linq;

// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

class SubStringInText
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        Console.Write("Enter a sub-string: ");
        string subStr = Console.ReadLine();
        str = str.ToLower();
        int count = 0;
        int index = str.IndexOf(subStr, 0);
        while (index != -1)
        {
            count++;
            index = str.IndexOf(subStr, index + 1);
        }
        Console.WriteLine("The sub-string is contained in a given text {0} times !", count);
    }
}

