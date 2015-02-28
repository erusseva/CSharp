using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//	Write a program that reads a string from the console and lists all different words in the 
//  string along with information how many times each word is found.

class WordsCount
{
    static void Main()
    {
        //Console.WriteLine("Enter a string: ");
        //string str = Console.ReadLine();
        //Just for easy tetsting:
        string str = "Gmail experiencing an issue with autocomplete - Gmail autocomplete issue could confuse you into emailing the wrong person";
        string[] words = str.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
        var dict = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (dict.ContainsKey(word))
            {
                dict[word]++;
            }
            else
            {
                dict.Add(word, 1);
            }
        }
        foreach (var word in dict.OrderBy(key => key.Value))
        {
            Console.WriteLine("The word '{0}' appears {1} times", word.Key, word.Value);
        }
    }
}

