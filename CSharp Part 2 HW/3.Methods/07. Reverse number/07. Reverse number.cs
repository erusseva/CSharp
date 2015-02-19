using System;

class ReverseNumber
{   
    //Write a method that reverses the digits of given decimal number.

    static int DigitReverse(int input)
    {
        string number = input.ToString();
        string output = null;
        for (int i = 0; i < number.Length; i++)
        {
            output = output + number[number.Length - 1 - i];
        }
        return int.Parse(output);
    }
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int n = int.Parse(Console.ReadLine());
        int reversedN = DigitReverse(n);
        Console.WriteLine("The reversed number is: {0}", reversedN);
    }
}

