using System;
using System.Numerics;

//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter an integer n (n >= 0): ");
            int n = int.Parse(Console.ReadLine());
            BigInteger numerator = 1;
            BigInteger divisor = 1;
            if (n >= 0 && n < 100)
            {
                for (int i = 2 * n; i > n + 1; i--)
                {
                    numerator *= i;
                }
                for (int i = 1; i <= n; i++)
                {
                    divisor *= i;
                }
                BigInteger result = numerator / divisor;
                Console.WriteLine("The {0}th Catalan number is: {1}", n, result);
            }
            else
            {
                Console.WriteLine("You must enter an integer value (n >= 0)!");
            }
        }
    }
}
