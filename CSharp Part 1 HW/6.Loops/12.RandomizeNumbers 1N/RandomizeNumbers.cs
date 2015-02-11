using System;

//Write a program that enters an integer n and prints the numbers 1, 2, …, n in random order.

namespace _12.RandomizeNumbers_1N
{
    class RandomizeNumbers
    {
        static void Main()
        {
            Console.Write("Enter how many random numbers will be printed: ");
            int count = int.Parse(Console.ReadLine());
            int[] pool = new int[count];
            bool[] printed = new bool[count + 1];
            Random randomN = new Random();
            int randomized = randomN.Next(1, count + 1);
            
            Console.WriteLine("Random numbers:");
            for (int i = 0; i < count; i++)
            {
                randomized = randomN.Next(1, count + 1);
                if (!printed[randomized])
                {
                    Console.Write("{0} ", randomized);
                    printed[randomized] = true;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine();
        }
    }
}
