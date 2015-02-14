using System;
using System.Linq;

//Write a program that reads two arrays from the console and compares them element by element.

class AreTwoArraysEqual
{
    static void Main()
    {
        Console.Write("Enter an integer for length of the first array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        Initialize(arr1);
        Console.Write("Enter an integer for length of the second array: ");
        int m = int.Parse(Console.ReadLine());
        int[] arr2 = new int[m];
        Initialize(arr2);

        CompareArrays(arr1, arr2);
    }

    private static void Initialize(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    private static void CompareArrays(int[] firstArray, int[] secondArray)
    {
        if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine("First array > Second array");
        }
        else if (firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("First array < Second array");
        }
        else
        {
            Console.Write("These arrays have equal length");

            if (firstArray.Where((t, i) => t != secondArray[i]).Any())
            {
                Console.WriteLine(", but different elements.");
                return;
            }
            Console.WriteLine("and equal elements.");
        }
    }
}