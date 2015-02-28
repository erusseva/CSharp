using System;

//	Write a program that reads a list of words, separated by spaces 
//  and prints the list in an alphabetical order.

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter a list of words, separated by spaces: ");
        string str = Console.ReadLine();
        string[] words = str.Split(' ');
        Array.Sort(words);
        Console.WriteLine("The words in an alphabetical order: ");
        Console.WriteLine(string.Join(" ", words));
    }
}
