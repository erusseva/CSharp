using System;

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("Enter the first integer: ");
            int bigger = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int lesser = int.Parse(Console.ReadLine());
            Console.Write("The GCD of {0} and {1} is: "
            , bigger, lesser);
            if (bigger < lesser)
            {
                bigger = bigger + lesser;
                lesser = bigger - lesser;
                bigger = bigger - lesser;
            }
            int divisor = (bigger % lesser);
            while (divisor != 0)
            {
                bigger = lesser;
                lesser = divisor;
                divisor = bigger % lesser;
            }
            Console.WriteLine("{0}", lesser);
        }
    }
}
