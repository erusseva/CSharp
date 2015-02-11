using System;
using System.Numerics;

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).

namespace _06.CalculateNKFactorial
{
    class CalculateNKFactorial
    {
        static void Main()
        {
            Console.Write("Enter a positive integer for n (n > 1): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a positive integer for k (k < n <100): ");
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            if (1 < k && k < n && n < 100)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    result *= i;
                }
            }
            else
            {
                Console.WriteLine("You must enter a positive integer value!");
            }
            Console.WriteLine("n! / k! = {0}", result);
        }
    }
}
