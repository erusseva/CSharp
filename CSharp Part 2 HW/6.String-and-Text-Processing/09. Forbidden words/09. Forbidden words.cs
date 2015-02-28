using System;
using System.Text;
using System.Linq;

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

class ForbiddenWords
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        Console.Write("Enter the forbidden words separated by a space: ");
        string[] words = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();

        StringBuilder newStr = new StringBuilder();
        newStr.Append(str);
        foreach (string word in words)
        {
            newStr.Replace(word, new string('*', word.Length));
        }
        Console.WriteLine(newStr);
    }
}

