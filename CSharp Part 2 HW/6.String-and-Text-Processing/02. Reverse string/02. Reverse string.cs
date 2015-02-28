using System;
using System.Linq;
using System.Collections.Generic;

//	Write a program that reads a string, reverses it and prints the result at the console.

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        char[] strToChar = str.ToCharArray();
        Array.Reverse(strToChar);
        Console.WriteLine("The reversed string is:");
        Console.WriteLine(strToChar);
    }
}
