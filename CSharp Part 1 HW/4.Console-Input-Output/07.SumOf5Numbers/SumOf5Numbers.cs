using System;
using System.Threading;
using System.Globalization;

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

namespace _07.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Change the decimal separator to "." (to avoid an exception for ",").

            Console.Write("Enter 5 numbers (given in a single line, separated by a space): ");

            string[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += double.Parse(input[i]);
            }
            Console.WriteLine("The sum is : {0}", sum);
        }
    }
}
