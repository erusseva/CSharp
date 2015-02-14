using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads an array of integers and removes from it a minimal number of
//elements in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.

namespace _18.RemoveElementsFromArray
{
    class RemoveElementsFromArray
    {
        static List<int>[] allBestSubsets = new List<int>[40];
        static int index = 0;
        static void Main()
        {
            Console.Write("Enter an integer for length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Arr[{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            FindAllSubsetsWithGivenSum(numbers);
            PrintTheLongestSubsets(numbers);
        }
        static void PrintTheLongestSubsets(int[] numbers)
        {
            Console.Clear();
            Console.WriteLine("Result: ");
            for (int i = 0; i < index; i++) Console.WriteLine(string.Join(", ", allBestSubsets[i]));
        }
        static void FindAllSubsetsWithGivenSum(int[] numbers)
        {
            List<int> subset = new List<int>();
            long maxLength = 0;
            long totalSubsets = (long)(Math.Pow(2, numbers.Length) - 1);
            for (long i = totalSubsets; i >= 1; i--)
            {
                long elementInSubset = ElementsInSubset(i);
                if (elementInSubset < maxLength) continue;
                subset.Clear();
                subset.AddRange(numbers.Where((t, j) => ((i >> j) & 1) == 1));
                if (IsIncreasingElements(subset))
                {
                    if (maxLength < elementInSubset)
                    {
                        allBestSubsets = new List<int>[40];
                        index = 0;
                    }
                    maxLength = elementInSubset;
                    allBestSubsets[index++] = new List<int>(subset);
                }
            }
        }
        static long ElementsInSubset(long currentNumber)
        {
            long elementsInSubset = 0;
            while (currentNumber != 0)
            {
                elementsInSubset += currentNumber & 1;
                currentNumber >>= 1;
            }
            return elementsInSubset;
        }
        static bool IsIncreasingElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
                if (numbers[i] > numbers[i + 1])
                    return false;
            return true;
        }

    }
}
