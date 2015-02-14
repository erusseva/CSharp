using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that finds the sequence of maximal sum in given array.

namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            Console.Write("Enter an integer for length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int currentSum = arr[0];
            int start = 0;
            int end = 0;
            int step = 0;
            int maxSum = arr[0];

            for (int i = 0; i < n; i++)
            {
                if (currentSum <= 0)
                {
                    start = i;
                    currentSum = 0;
                }

                currentSum += arr[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    step = start;
                    end = i;
                }
            }
            Console.Write("The sequence of maximal sum in this array is: ");
            for (int i = start; i <= end; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
