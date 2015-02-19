using System;

class SequenceNMatrix
{
    /*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
    neighbour elements located on the same line, column or diagonal.
    Write a program that finds the longest sequence of equal strings in the matrix.
    Example:
    matrix				result					matrix			result
    ha	fifi ho	hi								s	qq	s		s, s, s
    fo	ha	 hi	xx		ha, ha, ha				pp	pp	s
    xxx	ho	 ha	xx								pp	qq	s
    */
    
    static void Main()
    {
        string[,] matrix = new string[,] { { "ha", "fifi", "ho", "hi" },     //The example matrix!
                                            { "fo", "ha", "hi", "xx" }, 
                                            { "xxx", "ho", "ha", "xx" } };
        int counter = 1;
        int maxCount = 1;
        string maxValue = "";
        int direction = 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if ((matrix[row, col] == matrix[row, col + 1]))
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    maxValue = matrix[row, col];
                    direction = 1;
                }
            }
            counter = 1;
        }

        for (int col = 0; col < matrix.GetLength(1); col++) 
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if ((matrix[row, col] == matrix[row + 1, col]))
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    maxValue = matrix[row, col];
                    direction = 2;
                }
            }
            counter = 1;
        }

        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (counter > maxCount)
            {
                maxCount = counter;
                maxValue = matrix[row, col];
                direction = 3;
            }
        }
        counter = 1;

        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (counter > maxCount)
            {
                maxCount = counter;
                maxValue = matrix[row, col];
                direction = 4;
            }
        }
        counter = 1;

        switch (direction)
        {
            case 1: Console.WriteLine("The element \"{0}\" appears {1} times horizontally.", maxValue, maxCount); break;
            case 2: Console.WriteLine("The element \"{0}\" appears {1} times vertically.", maxValue, maxCount); break;
            case 3: Console.WriteLine("The element \"{0}\" appears {1} times diagonally from right to left.", maxValue, maxCount); break;
            case 4: Console.WriteLine("The element \"{0}\" appears {1} times diagonally from left to right.", maxValue, maxCount); break;
            default: Console.WriteLine("There are no equal strings in the matrix !"); break;
        }
    }
}

