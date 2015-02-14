using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

namespace _15.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            bool[] numbers = new bool[10000000];
            for (int i = 2; i < Math.Sqrt(numbers.Length); i++)
            {
                if (numbers[i] == false)
                {
                    for (int j = i * i; j < numbers.Length; j += i)
                    {
                        numbers[j] = true;
                    }
                }
            }
            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] == false)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
