using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].

namespace _21.CombinationsOfSet
{
    class CombinationsOfSet
    {
            static void Combinations(int nRange, int kCount, int[] arrInput, int position, int start)
            {
                if (position == kCount)
                {
                    Console.Write(arrInput[0]);
                    for (int i = 1; i < kCount; i++)
                    {
                        Console.Write(", " + arrInput[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int i = start; i <= nRange; i++)
                    {
                        arrInput[position] = i;
                        Combinations(nRange, kCount, arrInput, position + 1, start + 1);
                        start++;
                    }
                }
            }
            static void Main()
            {
                Console.Write("Enter a positive integer N: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Enter a positive integer K: ");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("Result:");
                int[] combos = new int[k];
                Combinations(n, k, combos, 0, 1);
            }
    }
}
