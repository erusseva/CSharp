using System;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).

namespace _03.MinMaxSumAndAverageOfN
{
    class MinMaxSumAndAverageOfN
    {
        static void Main()
        {            
            Console.Write("Enter a positive integer n: ");
            int input = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < input; i++)
            {
                Console.Write("Enter the {0} integer: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
                sum += number;
            }
            double average = (double)sum / input;
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}", min, max, sum, average);
        }
    }
}
