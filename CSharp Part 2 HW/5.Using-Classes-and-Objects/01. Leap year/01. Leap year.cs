using System;

class LeapYear
{
    //	Write a program that reads a year from the console and checks whether it is a leap one.

    static void Main()
    {
        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        Console.Write("The year {0} is ", year);
        if (!isLeap)
        {
            Console.Write("not ");
        }
        Console.WriteLine("a leap year!");
    }
}

