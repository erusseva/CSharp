using System;

//	Write a program that extracts from a given text all sentences containing given word.

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        string[] sentences = str.Split(new char[]{'.'}, StringSplitOptions.RemoveEmptyEntries);

        foreach (string sentence in sentences)
        {
            string checkSentence = sentence.ToLower();
            int index = checkSentence.IndexOf(word.ToLower() + " ");

            if (index > -1)
            {
                Console.Write(sentence.Trim());
                Console.WriteLine(".");
            }
        }
    }
}

