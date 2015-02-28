using System;

// Write a program that reads a string from the console and prints all different letters in the 
// string along with information how many times each letter is found.

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        char[] letters = new char[255];
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsLetter(str[i]))
            {
                letters[str[i]]++;
            }
        }
        for (int i = 0; i < letters.Length; i++)
        {
            if (char.IsLetter((char)i) && letters[i] > 0)
            {
                Console.WriteLine("The letter '{0}'appears {1} times", (char)i, (int)letters[i]);
            }
        }
    }
}

