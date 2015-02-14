using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

namespace _06.MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            Console.Write("Enter an integer N for length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} numbers: ", n);
            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter an integer K for greatest elements count: ");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i < k; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The sum of the greatest {0} numbers in the array is {1}.", k, sum);
        }
    }
}
