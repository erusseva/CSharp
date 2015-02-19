using System;
using System.Collections.Generic;
using System.Linq;

//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S


namespace _16.SubsetWithSumS
{
    class SubsetWithSumS
    {
        static void Main()
        {
            Console.Write("Enter a sum S: ");
            int wantedSum = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer for length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
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
                if ((sum == wantedSum) && (subset.Count > 1))
                {
                    counter++;
                    if (counter == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("YES, there are subsets of array's elements that has a sum S ({0}):", wantedSum);
                    }
                    Console.WriteLine();
                    Console.WriteLine(string.Join(", ", subset));
                }
                sum = 0;
                subset.Clear();
            }
            if (counter == 0)
            {
                Console.Clear();
                Console.WriteLine("NO, there is no subset of array's elements that has a sum S ({0}).", wantedSum);
            }
        }
    }
}
