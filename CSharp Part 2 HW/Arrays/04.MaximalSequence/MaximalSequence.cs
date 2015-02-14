using System;
using System.Collections.Generic;

//Write a program that finds the maximal sequence of equal elements in an array.

namespace _04.MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            Console.Write("Enter an integer for length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int maxSequence = 1;
            int currentSeq = 1;
            int maxN = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }
                if (currentSeq >= maxSequence)
                {
                    maxSequence = currentSeq;
                    maxN = arr[i];
                }
            }
            Console.WriteLine("The maximal sequence of equal elements in this array is: ");
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write("{0} ", maxN);
            }
            Console.WriteLine();
        }
    }
}
