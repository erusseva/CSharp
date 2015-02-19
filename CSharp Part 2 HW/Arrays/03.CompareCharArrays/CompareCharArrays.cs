using System;
using System.Linq;

//Write a program that compares two char arrays lexicographically (letter by letter).

class AreTwoArraysEqual
{
    static void Main()
    {
        Console.Write("Enter an integer for length of the first array: ");
        int n = int.Parse(Console.ReadLine());
        char[] arr1 = new char[n];
        Initialize(arr1);
        Console.Write("Enter an integer for length of the second array: ");
        int m = int.Parse(Console.ReadLine());
        char[] arr2 = new char[m];
        Initialize(arr2);

        CompareArrays(arr1, arr2);
    }

    private static void Initialize(char[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = char.Parse(Console.ReadLine());
        }
    }

    private static void CompareArrays(char[] firstArray, char[] secondArray)
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