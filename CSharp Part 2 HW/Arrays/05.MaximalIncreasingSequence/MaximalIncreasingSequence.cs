using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that finds the maximal increasing sequence in an array.

namespace _05.MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            Console.Write("Enter an integer for length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int maxSeq = 1;
            int currentSeq = 1;
            string currentN = "";
            string maxN = "";
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    currentSeq++;
                    currentN += arr[i] + " ";
                }
                else
                {
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        currentN += arr[i] + " ";
                        maxN = currentN;
                    }
                    currentSeq = 1;
                    currentN = "";
                }
            }
            if (currentSeq > maxSeq)
            {
                currentN += arr[arr.Length - 1];
                maxN = currentN;
            }
            Console.WriteLine("The maximal increasing sequence in this array is: ");
            Console.WriteLine(maxN);
        }
    }
}
