using System;

class EnglishDigit
{
    //Write a method that returns the last digit of given integer as an English word.
    
    static string GetLastDigit(int input)
    {
        string digitAsWord = null;
        string inputAsString = input.ToString();
        switch (inputAsString[inputAsString.Length - 1])
        {
            case '0': digitAsWord = "The last digit is zero"; break;
            case '1': digitAsWord = "The last digit is one"; break;
            case '2': digitAsWord = "The last digit is two"; break;
            case '3': digitAsWord = "The last digit is three"; break;
            case '4': digitAsWord = "The last digit is four"; break;
            case '5': digitAsWord = "The last digit is five"; break;
            case '6': digitAsWord = "The last digit is six"; break;
            case '7': digitAsWord = "The last digit is seven"; break;
            case '8': digitAsWord = "The last digit is eight"; break;
            case '9': digitAsWord = "The last digit is nine"; break;
        }
        return digitAsWord;
    }
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigit(input));
    }
}

