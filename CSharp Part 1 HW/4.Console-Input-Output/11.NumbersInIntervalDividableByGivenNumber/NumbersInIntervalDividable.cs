using System;

//Write a program that reads two positive integer numbers and prints how many numbers p 
//exist between them such that the reminder of the division by 5 is 0

namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividable
    {
        static void Main()
        {
            Console.Write("Enter the first positive integer: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the second positive integer: ");
            int end = int.Parse(Console.ReadLine());
            int count = 0;
            if (end % 5 == 0 && start % 5 == 0)
                ++count;
            end /= 5;
            start /= 5;
            count += Math.Abs(end - start);
            Console.WriteLine("{0} numbers exist between entered numbers, that the reminder of their division by 5 is 0", count);
        }
    }
}
