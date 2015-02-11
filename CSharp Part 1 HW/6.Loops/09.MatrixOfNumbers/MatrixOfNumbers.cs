using System;

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below.

namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter a positive integer for n (1 <= n <= 20): ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0 && n <= 20)
            {
                Console.WriteLine("matrix: ");
                for (int row = 1; row <= n; row++)
                {
                    for (int column = 0; column < n; column++)
                    {
                        Console.Write("{0,2} ", column + row);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("You must enter a positive integer value (1 <= n <= 20) !");
            }
        }
    }
}
