using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

namespace _20.VariationsOfSet
{
    class VariationsOfSet
    {
        static void Combinations(int nRange, int kCount, int[] arrInput, int position)
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
                for (int i = 1; i <= nRange; i++)
                {
                    arrInput[position] = i;
                    Combinations(nRange, kCount, arrInput, position + 1);
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
            Combinations(n, k, combos, 0);
        }
    }
}
