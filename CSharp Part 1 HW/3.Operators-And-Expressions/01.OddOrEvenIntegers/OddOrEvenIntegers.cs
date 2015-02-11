using System;

// Write an expression that checks if given integer is odd or even.

namespace _01.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer: ");
            int intNumber = int.Parse(Console.ReadLine());
            bool check = intNumber % 2 == 0;

            Console.WriteLine("Even number? {0}",
                check);
        }
    }
}
