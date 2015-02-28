using System;
using System.Text;

//	Write a program that reverses the words in given sentence.

class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        string str = Console.ReadLine();
        //string str = "C# is not C++, not PHP and not Delphi!"; --> easy testing

        char rev = str[str.Length - 1];

        string[] words = str.Substring(0, str.Length - 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(words[words.Length - 1 - i]);
            Console.Write(" ");
        }
        Console.WriteLine(rev);
    }
}

