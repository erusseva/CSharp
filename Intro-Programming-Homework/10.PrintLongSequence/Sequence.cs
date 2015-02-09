using System;

// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

namespace _10.PrintLongSequence
{
    class Sequence
    {
        static void Main()
        {
            int count = 1000;

            for (int member = 2; member <= count; member++)
            {
                Console.WriteLine(member);
                member++;
                Console.WriteLine(-member);
            }
        }
    }
}
