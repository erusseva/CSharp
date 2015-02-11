using System;
using System.Threading;
using System.Globalization;

//Write a program that finds the biggest of three numbers.

namespace _5.TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Change the decimal separator to "." (to avoid an exception for ",").
            
            Console.Write("Enter the first number: ");
            double firstN = Double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondN = Double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double thirdN = Double.Parse(Console.ReadLine());
            
            double biggestNumber = 0;
            biggestNumber = firstN >= secondN ? firstN : secondN;
            biggestNumber = biggestNumber >= thirdN ? biggestNumber : thirdN;
            Console.WriteLine("The biggest number is: " + biggestNumber);
        }
    }
}
