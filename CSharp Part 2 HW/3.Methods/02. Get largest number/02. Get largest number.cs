using System;

class GetLargestNumber
{
    //Write a method GetMax() with two parameters that returns the larger of two integers.
    //Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

    static int GetMax(int one, int two, int three)
    {
        return Math.Max(Math.Max(one, two), three);
    }
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter the third integer: ");
        int third = int.Parse(Console.ReadLine());
        int maximum = GetMax(first, second, third);
        Console.WriteLine("The max number is: " + maximum);
    }
}

