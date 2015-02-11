using System;
using System.Threading;
using System.Globalization;

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

namespace _4.NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            //Change the decimal separator to "." (to avoid an exception for ",").
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double checkGreater = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("The greater number is: {0}\n", checkGreater);
        }
    }
}
