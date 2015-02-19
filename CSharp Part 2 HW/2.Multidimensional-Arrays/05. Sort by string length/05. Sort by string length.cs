using System;

class SortByStringLengh
{
    //You are given an array of strings. Write a method that sorts the array by the length of its 
    // elements (the number of characters composing them).

    static void Main()
    {
        Console.Write("Enter a positive integer N: ");
        int n = int.Parse(Console.ReadLine());

        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the {0} element : ", i + 1);
            arr[i] = Console.ReadLine();
        }
        string exchanger = null;
        int indexer = 0;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            exchanger = arr[i];
            count = 0;
            for (int j = i; j < n; j++)
            {
                if (arr[j].Length > count)
                {
                    count = arr[j].Length;
                    indexer = j;
                    exchanger = arr[j];
                }
            }
            arr[indexer] = arr[i];
            arr[i] = exchanger;
        }
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
