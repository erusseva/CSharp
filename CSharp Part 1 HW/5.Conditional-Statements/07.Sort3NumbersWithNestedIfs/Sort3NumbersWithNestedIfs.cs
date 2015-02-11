using System;
using System.Threading;
using System.Globalization;

// Write a program that enters 3 real numbers and prints them sorted in descending order. 

namespace _07.Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter the first number: ");
            double firstN = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondN = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double thirdN = double.Parse(Console.ReadLine());
            if (thirdN > secondN)
            {
                thirdN = thirdN + secondN;
                secondN = thirdN - secondN;
                thirdN = thirdN - secondN;
            }
            if (thirdN > firstN)
            {
                thirdN = thirdN + firstN;
                firstN = thirdN - firstN;
                thirdN = thirdN - firstN;
            }
            if (secondN > firstN)
            {
                secondN = secondN + firstN;
                firstN = secondN - firstN;
                secondN = secondN - firstN;
            }
            Console.WriteLine("Result is: {0} {1} {2}", firstN, secondN, thirdN);
        }
    }
}
