using System;
using System.Threading;
using System.Globalization;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Change the decimal separator to "." (to avoid an exception for ",").

            Console.Write("Enter the first real number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the second real number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the third real number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            int signCounter = 0;
            if ((firstNumber == 0) || (secondNumber == 0) || (thirdNumber == 0))
            {
                Console.WriteLine("Result: 0");
            }
            else
            {
                if (firstNumber < 0)
                {
                    signCounter++;
                }
                if (secondNumber < 0)
                {
                    signCounter++;
                }
                if (thirdNumber < 0)
                {
                    signCounter++;
                }
                if (signCounter % 2 == 0)
                {
                    Console.WriteLine("Result: + ");
                }
                else
                {
                    Console.WriteLine("Result: - ");
                }
            }
        }
    }
}
