using System;
using System.Collections.Generic;

class MaximalSum
{
    //Write a program that reads a rectangular matrix of size N x M
    //and finds in it the square 3 x 3 that has maximal sum of its elements.

    static void Main()
    {
        Console.Write("Enter a positive integer for M (rows >= 3): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a positive integer for N (cols >= 3): ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        
        while ((n < 3) || (m < 3))
        {
            if (n < 3)
            {
                Console.Write("N has to be >= 3 !");
                n = int.Parse(Console.ReadLine());
            }
            if (m < 3)
            {
                Console.Write("M has to be >= 3 !");
                m = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("Enter an element of the {0} row and the {1} col : ", i + 1, j + 1);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();

        if ((n == 3) && (m == 3))
        {
            Console.WriteLine("The entered matrix is already 3 x 3 !");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}".PadLeft(3, ' '), matrix[i, j]);
                }
                Console.WriteLine();
            }
            return;
        }

        int max = 0;
        int tempSum = 0;
        int maxRow = 0;
        int maxCol = 0;
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                tempSum = 0;
                for (int row = i; row < i + 3; row++)
                {
                    for (int col = j; col < j + 3; col++)
                    {
                        tempSum += matrix[row, col];
                    }
                }
                if (tempSum > max)
                {
                    max = tempSum;
                    maxRow = i;
                    maxCol = j;
                }
            }
        }
        Console.WriteLine("The square 3 x 3 that has maximal sum of its elements is:");
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("{0, 4}", matrix[maxRow + i, maxCol + j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();   
        Console.WriteLine("The maximum sum is " + max);
        Console.WriteLine();
    }   
}

