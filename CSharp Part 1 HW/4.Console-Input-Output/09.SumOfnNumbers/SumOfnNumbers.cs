using System;
using System.Threading;
using System.Globalization;

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

namespace _09.SumOfnNumbers
{
    class SumOfnNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Change the decimal separator to "." (to avoid an exception for ",").

            Console.Write("How many numbers you will enter: ");
            double count = double.Parse(Console.ReadLine());
            double sum = 0;
            for (double i = 0; i < count; i++)
            {
                Console.Write("Enter the {0} number: ", i + 1);
                double value = double.Parse(Console.ReadLine());
                sum += value;
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
