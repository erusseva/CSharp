using System;
using System.Text;
using System.Collections.Generic;

// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.

class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        Console.Write("Enter the word you want to be explained: ");
        string word = Console.ReadLine();
            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine(dictionary[word]);
            }
            else
            {
                Console.WriteLine("This word doesn't exist in the dictionary!");
            }
    }
}
