using System;

class BinarySearch
{
    /*•	Write a program, that reads from the console an array of N integers and an integer K, 
 * sorts the array and using the method Array.BinSearch() finds the largest number in the 
 * array which is ≤ K.*/
   
    static void Main()
    {
        Console.Write("Enter an integer K: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter a positive integer N: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the {0} element : ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        arr[n] = k;
        Array.Sort(arr);

        int indexK = Array.BinarySearch(arr, k);

        if (indexK == n)
        {
            Console.WriteLine(arr[n - 1]);
        }
        else if (arr[indexK] == arr[indexK + 1])
        {
            Console.WriteLine("The largest number in the array which is <= K is: {0}", arr[indexK]);
        }
        else if (indexK == 0)
        {
            Console.WriteLine("All elements are larger than K !");
        }
        else
        {
            Console.WriteLine("The largest number in the array which is <= K is: {0}", arr[indexK - 1]);
        }
    }
}

