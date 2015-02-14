using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that finds the most frequent number in an array.

namespace _09.FrequentNumber
{
    class FrequentNumber
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
            int counter = 1;
            int maxCount = 1;
            int countedN = 0;
            Array.Sort(arr);
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    countedN = arr[i];
                }
            }
            if (maxCount > 1)
            {
                Console.WriteLine("The most frequent number in this array is: {0} ({1} times).", countedN, maxCount);
            }
            else
            {
                Console.WriteLine("There is no frequency");
            }
        }
    }
}
