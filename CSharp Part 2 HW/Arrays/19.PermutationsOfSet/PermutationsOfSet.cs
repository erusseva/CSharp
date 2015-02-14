using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

namespace _19.PermutationsOfSet
{
    class PermutationsOfSet
    {
        static void Main()
        {
            Console.Write("Enter a positive integer N: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            bool[] used = new bool[n];
            Console.WriteLine("Result:");
            Permute(vector, n, used, 0);
        }
        private static void Permute(int[] vector, int n, bool[] used, int index)
        {
            if (index == n)
            {
                Print(vector);
            }
            for (int i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    vector[index] = i + 1;
                    Permute(vector, n, used, index + 1);
                    used[i] = false;
                }
            }
        }
        private static void Print(int[] vector)
        {
            Console.Write(vector[0]);
            for (int i = 1; i < vector.Length; i++)
            {
                Console.Write(", " + vector[i]);
            }
            Console.WriteLine();
        }
    }
}
