using System;

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.Write("Enter how many random numbers will be printed: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Enter a min integer for the range: ");
            int minNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter a max integer for the range: ");
            int maxNumber = int.Parse(Console.ReadLine());
            Random randomN = new Random();
            Console.WriteLine("Random numbers:");
            
            for (int i = 1; i <= count; i++)
            {
                Console.Write("{0} ", randomN.Next(minNumber, maxNumber + 1));
            }
        }
    }
}
