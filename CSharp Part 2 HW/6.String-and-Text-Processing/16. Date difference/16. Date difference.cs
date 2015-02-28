using System;

//	Write a program that reads two dates in the format:
//  day.month.year and calculates the number of days between them.

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter a date in format <day.month.year>: ");
        string[] date = Console.ReadLine().Split('.');
        int day = int.Parse(date[0]);
        int month = int.Parse(date[1]);
        int year = int.Parse(date[2]);
        DateTime firstDate = new DateTime(year, month, day);

        Console.Write("Enter the second date in format <day.month.year>: ");
        string[] date2 = Console.ReadLine().Split('.');
        int day2 = int.Parse(date2[0]);
        int month2 = int.Parse(date2[1]);
        int year2 = int.Parse(date2[2]);
        DateTime secondDate = new DateTime(year2, month2, day2);

        int distance = Math.Abs((firstDate - secondDate).Days);
        Console.WriteLine("Distance: {0} days", distance);
    }
}

