using System;
using System.Numerics;

//Task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 

namespace _07.CalculateCombinations
{
    class CalculateCombinations
    {
        static void Main()
        {
            Console.Write("Enter a positive integer for n (n > 1): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a positive integer for k (k < n <100): ");
            int k = int.Parse(Console.ReadLine());
            BigInteger numerator = 1;
            BigInteger divisor = 1;
            
            if (1 < k && k < n && n < 100)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    numerator *= i;
                }
                for (int j = 1; j <= (n - k); j++)
                {
                    divisor *= j;
                }
            }
            else
            {
                Console.WriteLine("You must enter a positive integer value!");
            }
            BigInteger result = numerator / divisor;
            Console.WriteLine("n! / (k!*(n-k)!) = {0}", result);
        }
    }
}
