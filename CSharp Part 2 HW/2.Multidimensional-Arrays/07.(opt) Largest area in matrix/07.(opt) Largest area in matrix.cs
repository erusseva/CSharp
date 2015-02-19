using System;

class LargestAreaInMatrix
{        
 //Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

    static int answer = 0;
    static int absMax = 0;
    static int[,] matrix = new int[,] { { 1, 3, 2, 2, 2, 4 }, // The example matrix!
                                        { 3, 3, 3, 2, 4, 4 }, 
                                        { 4, 3, 1, 2, 3, 3 }, 
                                        { 4, 3, 1, 3, 3, 1 }, 
                                        { 4, 3, 3, 3, 1, 1 } };
    static void Main()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                FindTheArea(i, j, matrix[i, j]);
                answer = 0;
            }
        }
        Console.WriteLine("Result:");
        Console.WriteLine(absMax);
    }

    private static void FindTheArea(int i, int j, int currentElement)
    {

        if ((currentElement == 0) || (i < 0) || (i >= matrix.GetLength(0)) || (j < 0) || (j >= matrix.GetLength(1)))
        {
            return;
        }

        if (matrix[i, j] == currentElement)
        {
            matrix[i, j] = 0;

            answer++;

            if (absMax < answer)
            {
                absMax = answer;
            }

            FindTheArea(i + 1, j, currentElement);

            FindTheArea(i - 1, j, currentElement);

            FindTheArea(i, j + 1, currentElement);

            FindTheArea(i, j - 1, currentElement);

            matrix[i, j] = currentElement;

        }

    }
}

