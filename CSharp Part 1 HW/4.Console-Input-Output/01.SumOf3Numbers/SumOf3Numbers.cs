using System;
using System.Globalization;
using System.Threading;

//Write a program that reads 3 real numbers from the console and prints their sum.

namespace _01.SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            // First - change the decimal separator to "." (to avoid an exception).
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter the first real number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second real number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter the third real number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            double sum = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine("The sum of these real numbers is: {0}", sum);
        }
    }
}
