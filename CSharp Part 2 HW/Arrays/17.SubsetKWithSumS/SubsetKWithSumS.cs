using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.


namespace _17.SubsetKWithSumS
{
    class SubsetKWithSumS
    {
        static void Main()
        {
            Console.Write("Enter a sum S (integer): ");
            int wantedSum = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer for K elements: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer for length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int subsetsCounter = 0;
            int sum = 0;
            int[] array = new int[n];
            List<int> subset = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Arr[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int allSubsets = (int)Math.Pow(2, n) - 1;
            for (int i = 0; i < allSubsets; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    int mask = (i & (1 << j));
                    int bit = mask >> j;
                    if (bit == 1)
                    {
                        sum += array[j];
                        subset.Add(array[j]);
                    }
                }
                if ((sum == wantedSum) && (subset.Count == k))
                {
                    subsetsCounter++;
                    if (subsetsCounter == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("YES, there are subsets of {0} elements of that array that has a sum S ({1}):",
                        k, wantedSum);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Subset {0}: " + (string.Join(", ", subset)), subsetsCounter);
                }
                sum = 0;
                subset.Clear();
            }
            if (subsetsCounter == 0)
            {
                Console.Clear();
                Console.WriteLine("NO, there is no subset of array's elements that has a sum S ({0}).", wantedSum);
            }
        }
    }
}
