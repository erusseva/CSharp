using System;

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233...

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter count (an integer): ");
            int count = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 1;
            int sum;
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}, ", firstNumber);
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }
        }
    }
}
