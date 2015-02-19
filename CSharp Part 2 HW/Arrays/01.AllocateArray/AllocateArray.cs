using System;

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

namespace _01.AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int[] integers = new int[20];
            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = i * 5;
                Console.Write("{0}, ", integers[i]);
            }
            Console.WriteLine();
        }
    }
}
