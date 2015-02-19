using System;

class FillTheMatrix
{
    //Write a program that fills and prints a matrix of size (n, n) 
    
    static void Main()
    {
        Console.Write("Enter a positive integer for n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int digit = 1;

        Console.WriteLine("Matrix a) :");

        for (int col = 0; col < n; col++) 
        {
            for (int row = 0; row < n; row++)
            {
                matrix[col, row] = digit;
                digit++;
            }
        }

        for (int col = 0; col < n; col++) 
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();

        Console.WriteLine("Matrix b) :");

        for (int col = 0; col < n; col++)  
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[col, row] = digit;
                    digit++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[col, row] = digit;
                    digit++;
                }
            }
        }

        for (int col = 0; col < n; col++)   
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();

        Console.WriteLine("Matrix c) :");

        int rowC = n - 1;
        int colC = 0;
        int startRow = n - 1;
        int startCol = 0;

        while (digit < n * n)
        {
            if (rowC == (n - 1) && colC < (n - 1))   
            {
                if (digit == 1)
                {
                    matrix[colC, rowC] = digit;
                }
                startRow--;
                startCol = 0;
                rowC = startRow;
                colC = startCol;
                digit++;
                matrix[colC, rowC] = digit;

                while (rowC < (n - 1) && colC < (n - 1))
                {
                    rowC++;
                    colC++;
                    digit++;
                    matrix[colC, rowC] = digit;
                }
            }
            if (rowC <= (n - 1) && colC == (n - 1))
            {
                startRow = 0;
                startCol++;
                rowC = startRow;
                colC = startCol;
                digit++;
                matrix[colC, rowC] = digit;

                while (colC < (n - 1))
                {
                    colC++;
                    rowC++;
                    digit++;
                    matrix[colC, rowC] = digit;
                }
            }
        }
        for (int c = 0; c < n; c++)    
        {
            for (int r = 0; r < n; r++)
            {
                Console.Write("{0, 4}", matrix[r, c]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();

        Console.WriteLine("Matrix d) :");

        int equalize = 0;
        int rowD = 0;
        int colD = 0;
        while (digit <= n * n)
        {
            for (rowD = equalize; rowD < n - equalize; rowD++)
            {
                colD = equalize;
                matrix[rowD, colD] = digit;
                digit++;
            }
            for (colD = 1 + equalize; colD < n - equalize; colD++)
            {
                rowD = n - 1 - equalize;
                matrix[rowD, colD] = digit;
                digit++;
            }
            for (rowD = n - 2 - equalize; rowD >= equalize; rowD--)
            {
                colD = n - 1 - equalize;
                matrix[rowD, colD] = digit;
                digit++;
            }
            for (colD = n - 2 - equalize; colD >= equalize + 1; colD--)
            {
                rowD = equalize;
                matrix[rowD, colD] = digit;
                digit++;
            }
            equalize++;
        }

        for (int irow = 0; irow < n; irow++)  
        {
            for (int column = 0; column < n; column++)
            {
                Console.Write("{0, 4}", matrix[irow, column]);
            }
            Console.WriteLine();
        }
    }
}

