using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that sorts an array of strings using the Quick sort algorithm.

namespace _14.QuickSort
{
    class QuickSort
    {
        static void Main()
        {
            Console.Write("Enter a sentence (string): ");
            string str = Console.ReadLine();
            List<string> wordList = new List<string>(str.Split(" .,!:-'()}{".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine();
            TheQuickSort(wordList);
            foreach (string s in wordList)
                Console.Write(s + " ");
            Console.WriteLine();
        }

        static void TheQuickSort(List<string> arr)
        {
            if (arr.Count < 2)
                return;
            string pivot = arr[arr.Count / 2];
            List<string> leftArray = new List<string>();
            List<string> rightArray = new List<string>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (i == arr.Count / 2)
                    continue;
                if (string.Compare(arr[i], pivot) < 0)
                    leftArray.Add(arr[i]);
                else
                    rightArray.Add(arr[i]);
            }
            TheQuickSort(leftArray);
            TheQuickSort(rightArray);
            arr.Clear();
            arr.AddRange(leftArray);
            arr.Add(pivot);
            arr.AddRange(rightArray);
        }
    }
}
