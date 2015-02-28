using System;
using System.IO;

/*•	Write a program that reads a text file containing a square matrix of numbers.
  •	Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
    o	The first line in the input file contains the size of matrix N.
    o	Each of the next N lines contain N numbers separated by space.
    o	The output should be a single number in a separate text file.*/

class MaximalAreaSum
{
    static void Main()
    {
        string path = @"..\..\Input data.txt";
        string path2 = @"..\..\Output data.txt";
        StreamReader reader = new StreamReader(path);
        StreamWriter writer = new StreamWriter(path2, false);
        int n = int.Parse(reader.ReadLine());
        int[,] matrix = new int[n, n];
        int maxSum = 0;
        for (int i = 0; i < n; i++)
        {
            string[] numbers = new string[n];
            numbers = reader.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(numbers[j]);
            }
        }
        reader.Close();
        maxSum = FindMaxSum(n, matrix, maxSum);
        writer.WriteLine(maxSum);
        writer.Close();
    }
    private static int FindMaxSum(int n, int[,] matrix, int maxSum)
    {
        for (int i = 0; i < n - 1; i++)
        {
            int tempSum = 0;
            for (int j = 0; j < n - 1; j++)
            {
                tempSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (maxSum < tempSum)
                {
                    maxSum = tempSum;
                }
            }
        }
        return maxSum;
    }
}

