using System;
using System.Text;

//	Write a program that reads a string from the console and replaces all series 
//  of consecutive identical letters with a single one.

class SeriesOfLetters
{
    static void Main()
    {
        //Console.WriteLine("Enter a string: ");
        //string str = Console.ReadLine();
        //Just for easy tetsting:
        string str = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder letters = new StringBuilder();
        letters.Append(str[0]);
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] != str[i - 1])
            {
                letters.Append(str[i]);
            }
        }
        Console.WriteLine(letters.ToString());
    }
}

