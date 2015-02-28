using System;
using System.Linq;

class Workdays
{
    /*•	Write a method that calculates the number of workdays between today and given date, 
        * passed as parameter.
         •	Consider that workdays are all days from Monday to Friday except a fixed list of public 
        * holidays specified preliminary as array.*/

    static readonly DateTime[] holidays =
    {
    new DateTime(2015, 1, 1), new DateTime(2015, 1, 2), 
    new DateTime(2015, 3, 3), new DateTime(2015, 3, 2), 
    new DateTime(2015, 4, 10), new DateTime(2015, 4, 13), 
    new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
    new DateTime(2015, 9, 21), new DateTime(2015, 9, 22),
    new DateTime(2015, 12, 24), new DateTime(2015, 12, 25)
    };
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.Write("Enter a date between today and 31.12.2015 in format dd.MM.yyyy: ");
        int[] futureDateInput = Console.ReadLine().Split('.').Select(int.Parse).ToArray();
        DateTime futureDate = new DateTime(futureDateInput[2], futureDateInput[1], futureDateInput[0]);
        Console.WriteLine("The number of workdays between today and the given date is: {0}", WorkingDays(today, futureDate));
    }
    private static int WorkingDays(DateTime dateNow, DateTime futureDate)
    {
        int counter = 0;
        if (today > futureDate)
        {
            DateTime swap = dateNow;
            dateNow = futureDate;
            futureDate = swap;
        }
        while (dateNow <= futureDate)
        {
            if (!holidays.Contains(dateNow) && dateNow.DayOfWeek != DayOfWeek.Saturday && dateNow.DayOfWeek != DayOfWeek.Sunday)
            {
                counter++;
            }
            dateNow = dateNow.AddDays(1);
        }
        return counter;
    }


    public static DateTime today { get; set; }
}

