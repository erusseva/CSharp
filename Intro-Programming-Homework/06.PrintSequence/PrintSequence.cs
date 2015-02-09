using System;

// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

namespace _06.PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int count = 10;

            for (int member = 2; member <= count; member++)
            {
                Console.WriteLine(member);
                member++;
                Console.WriteLine(-member);
            }
        }
    }
}