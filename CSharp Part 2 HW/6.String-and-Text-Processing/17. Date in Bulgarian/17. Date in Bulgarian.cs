using System;
using System.Globalization;

/*•	Write a program that reads a date and time given in the format:
 * day.month.year hour:minute:second and prints the date and time 
 * after 6 hours and 30 minutes (in the same format) along with the 
 * day of week in Bulgarian.*/

class DateInBulgarian
{
    static void Main()
    {
        string str = "02.03.2015 22:30:03"; //easy testing

        DateTime date = DateTime.ParseExact(str, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6.5);

        Console.WriteLine("{1}, {0}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
    }
}
