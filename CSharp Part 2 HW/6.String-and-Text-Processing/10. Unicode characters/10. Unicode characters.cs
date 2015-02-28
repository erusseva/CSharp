using System;
using System.Text;

//	Write a program that converts a string to a sequence of C# Unicode character literals.
//	Use format strings.

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        StringBuilder unicodeL = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            unicodeL.AppendFormat("\\u{0:X4}", (int)str[i]);
        }

        Console.WriteLine(unicodeL.ToString());
    }
}

