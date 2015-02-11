using System;

// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

namespace _09.AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Write Your birthdate in the following format DD/MM/YYYY");
            string BDate = Console.ReadLine();

            DateTime birthDay = DateTime.Parse(BDate);
            DateTime now = DateTime.Now;

            TimeSpan span = now - birthDay;

            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime interval = (zeroTime + span);

            int year = interval.Year - 1;
            int month = interval.Month - 1;
            int days = interval.Day - 1;

            DateTime after10 = interval.AddYears(9);
            int after10Years = after10.Year;

            Console.WriteLine("Now You are {0} years, {1} months and {2} days old",
                year, month, days);
            Console.WriteLine("After 10 years You will be {0}-year-old", 
                after10Years);
        }
    }
}
