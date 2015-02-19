using System;
using System.Collections.Generic;

//* Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, 
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

public class Matrix
{
    private int[,] matrix;

    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    public int Columns
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    public int this[int row, int col] 
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    public override string ToString()
    {
        string answer = null;

        for (int i = 0; i < this.Rows; i++)
        {
            for (int j = 0; j < this.Columns; j++)
            {
                answer = answer + this.matrix[i, j] + " ";
            }
            answer = answer + "\n";
        }
        return answer;
    }

    public static Matrix Add(Matrix m1, Matrix m2) 
    {
        Matrix result = new Matrix(m1.Rows, m1.Columns);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = m1[i, j] + m2[i, j];
            }
        }
        return result;
    }

    public static Matrix Substract(Matrix m1, Matrix m2) 
    {
        Matrix result = new Matrix(m1.Rows, m1.Columns);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = m1[i, j] - m2[i, j];
            }
        }
        return result;
    }

    public static Matrix Multiply(Matrix m1, Matrix m2) 
    {
        Matrix result = new Matrix(m1.Rows, m2.Columns);

        for (int row = 0; row < m1.Rows; row++)
        {
            for (int col = 0; col < m2.Columns; col++)
            {
                int temp = 0;
                for (int currentnumbers = 0; currentnumbers < m1.Columns; currentnumbers++)
                {
                    temp = temp + m1[row, currentnumbers] * m2[currentnumbers, col];
                }
                result[row, col] = temp;
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        return Matrix.Multiply(m1, m2);
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        return Matrix.Add(m1, m2);
    }

    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        return Matrix.Substract(m1, m2);
    }
}

class ClassMatrixTester
{
    static void Main()
    {
        Matrix testMatrix1 = new Matrix(2, 3);
        testMatrix1[0, 0] = 5;
        testMatrix1[0, 1] = 6;
        testMatrix1[0, 2] = 7;

        testMatrix1[1, 0] = 8;
        testMatrix1[1, 1] = 9;
        testMatrix1[1, 2] = 3;

        Matrix testMatrix2 = new Matrix(3, 2);
        testMatrix2[0, 0] = 5;
        testMatrix2[0, 1] = 6;

        testMatrix2[1, 0] = 8;
        testMatrix2[1, 1] = 9;

        testMatrix2[2, 0] = 1;
        testMatrix2[2, 1] = 2;

        Matrix testMatrix3 = new Matrix(2, 3);
        testMatrix3[0, 0] = 1;
        testMatrix3[0, 1] = 2;
        testMatrix3[0, 2] = 3;

        testMatrix3[1, 0] = 4;
        testMatrix3[1, 1] = 5;
        testMatrix3[1, 2] = 6;


        Matrix resultAdd = Matrix.Add(testMatrix1, testMatrix3);
        var add = testMatrix1 + testMatrix3;

        Console.WriteLine(add);
        Console.WriteLine(resultAdd);

        Matrix resultSubstract = Matrix.Substract(testMatrix1, testMatrix3);
        var substract = testMatrix1 - testMatrix3;

        Console.WriteLine(resultSubstract);
        Console.WriteLine(substract);

        Matrix resultMultiply = Matrix.Multiply(testMatrix1, testMatrix2);
        var multiply = testMatrix1 * testMatrix2;

        Console.WriteLine(resultMultiply);
        Console.WriteLine(multiply);
    }
}