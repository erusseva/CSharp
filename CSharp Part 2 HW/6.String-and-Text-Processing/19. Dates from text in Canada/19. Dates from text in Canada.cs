using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;


//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

    class DatesFromTextInCanada
    {
        static void Main()
        {
            //Console.WriteLine("Enter a text: ");
            //string str = Console.ReadLine();
            //For easy tetsting:
            string str = "I was born on the first day of spring 21.03.1988 and your birthday is on 13.03.1988, so you are older than me...";

            foreach (var date in Regex.Matches(str, @"\w+\.\w+\.\w+"))
            {
                Console.WriteLine("{0}", date, CultureInfo.GetCultureInfo("en-CA"));
            }
        }
    }

