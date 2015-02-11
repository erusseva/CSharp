using System;
using System.Threading;
using System.Globalization;

//Write a program that finds the biggest of five numbers by using only five if statements.

namespace _06.TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter the first number: ");
            double firstN = Double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondN = Double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double thirdN = Double.Parse(Console.ReadLine());
            Console.Write("Enter the fourth: ");
            double fourthN = Double.Parse(Console.ReadLine());
            Console.Write("Enter the fifth number: ");
            double fifthN = Double.Parse(Console.ReadLine());
            double biggestN = firstN;
            if (biggestN <= secondN)
            {
                biggestN = secondN;
            }
            if (biggestN <= thirdN)
            {
                biggestN = thirdN;
            }
            if (biggestN <= fourthN)
            {
                biggestN = fourthN;
            }
            if (biggestN <= fifthN)
            {
                biggestN = fifthN;
            }
            Console.WriteLine("The biggest number is: " + biggestN);
        }
    }
}
