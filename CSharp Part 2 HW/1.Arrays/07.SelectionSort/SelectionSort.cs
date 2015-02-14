using System;
using System.Collections.Generic;
using System.Linq;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position,
//find the smallest from the rest, move it at the second position, etc.

namespace _07.SelectionSort
{
    class SelectionSort
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
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int step = arr[i];
                        arr[i] = arr[j];
                        arr[j] = step;
                    }
                }
            }
            Console.WriteLine("Sorting the array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
