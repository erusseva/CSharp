using System;

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.

namespace _05.CalculateFactorial
{
    class CalculateFactorialSum
    {
        static void Main()
        {
            Console.Write("Enter the first integer (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer (x): ");
            int x = int.Parse(Console.ReadLine());
            decimal xAtPowerN = 1.00m;
            decimal factorial = 1.00m;
            decimal sum = 1.00m;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                xAtPowerN *= x;
                sum += (factorial / xAtPowerN);
            }
            Console.WriteLine("Sum (1 + 1!/x + 2!/x^2 + … + n!/x^n): {0:F5}", sum);
        }
    }
}
