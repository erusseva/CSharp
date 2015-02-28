using System;
using System.Text;

//Write a program that reads from the console a string of maximum 20 characters. If the 
 //length of the string is less than 20, the rest of the characters should be filled with *.
 //Print the result string into the console.

class StringLength
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        StringBuilder newStr = new StringBuilder();
        int counter = 0;
        while (counter < str.Length && counter < 21)
        {
            newStr.Append(str[counter]); 
            counter++;
        }
        if (newStr.Length < 21)
        {
            newStr.Append(new string('*', 20 - newStr.Length));
        }
        Console.WriteLine(newStr.ToString());
    }
}
