using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that finds in given array of integers a sequence of given sum S (if present).

namespace _10.FindSumInArray
{
    class FindSumInArray
    {
        static void Main()
        {
            Console.Write("Enter an integer for length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter a sum S: ");
            int s = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int currentS = 0;
            int start = 0;

            for (int i = 0; i < n - 1; i++)
            {
                currentS += arr[i];
                start = i;
                for (int j = i + 1; j < n; j++)
                {
                    currentS += arr[j];
                    if (currentS == s)
                    {
                        for (int k = start; k <= j; k++)
                        {
                            Console.Write("{0} ", arr[k]);
                        }
                        break;
                    }
                }
                currentS = 0;
            }
            Console.WriteLine();
        }

    }
}
