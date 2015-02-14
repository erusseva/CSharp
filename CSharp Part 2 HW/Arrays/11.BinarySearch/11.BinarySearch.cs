using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static int BinSearch(int[] arr, int element)
        {
            Array.Sort(arr);
            int first = 0;
            int last = arr.Length - 1;
            while (last >= first)
            {
                int mid = (first + last) / 2;
                if (arr[mid] < element)
                {
                    first = mid + 1;
                }
                else if (arr[mid] > element)
                {
                    last = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
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
            int[] sortedArr = arr;
            Console.Write("Enter the element (integer!): ");
            int element = int.Parse(Console.ReadLine());
            Console.Write("The index of that element is: ");
            Console.WriteLine(BinSearch(sortedArr, element));
        }
    }
}
