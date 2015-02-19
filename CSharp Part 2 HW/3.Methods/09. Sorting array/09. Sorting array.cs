using System;

class SortingArray
{
   //Write a method that return the maximal element in a portion of array of integers starting at given index.
  //Using it write another method that sorts an array in ascending / descending order.
    
    static void ArrayInput(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter the {0} element: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }
    
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0, 4} ", arr[i]);
        }
        Console.WriteLine();
    }
    
    static int MaxElement(int startPos, int[] arr, ref int maxPos, int finishPos)
    {
        int max = arr[startPos];
        maxPos = startPos;
        for (int i = startPos; i < finishPos; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
                maxPos = i;
            }
        }
        return max;
    }
    
    static void AscendingSorter(int[] arr)
    {
        int max = 0;
        int maxPos = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            max = MaxElement(0, arr, ref maxPos, arr.Length - i);
            arr[maxPos] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = max;
        }
    }
    static void DescendingSorter(int[] arr)
    {
        int max = 0;
        int maxPos = 0;
        int[] SortedArray = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            max = MaxElement(i, arr, ref maxPos, arr.Length);
            arr[maxPos] = arr[i];
            arr[i] = max;
        }
    }
    
    static void Main()
    {
        Console.Write("Enter an integer for length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayInput = new int[n];
        ArrayInput(arrayInput);
        Console.Write("Enter the start position index for searching (from 0 to {0}): ", n - 1);
        int pos = int.Parse(Console.ReadLine());
        int posOfMaxEl = 0;
        int maxElement = MaxElement(pos, arrayInput, ref posOfMaxEl, arrayInput.Length);
        Console.WriteLine("The max element is {0} and its index is {1}", maxElement, posOfMaxEl);
        int[] arrayInputAscending = new int[n];
        int[] arrayInputDescending = new int[n];
        Array.Copy(arrayInput, arrayInputAscending, n);
        Array.Copy(arrayInput, arrayInputDescending, n);
        AscendingSorter(arrayInputAscending);
        DescendingSorter(arrayInputDescending);
        PrintArray(arrayInput);
        Console.WriteLine();
        Console.WriteLine("Sorting in ascending and descending order:");
        PrintArray(arrayInputAscending);
        Console.WriteLine();
        PrintArray(arrayInputDescending);
        Console.WriteLine();
    }
}
