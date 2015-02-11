using System;

// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

namespace _13.CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter an unsigned integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation of the number {0} is: {1}",
            n, Convert.ToString(n, 2).PadLeft(16, '0'));
      
            Console.Write("Enter a bit's position: ");
            int position = int.Parse(Console.ReadLine());
            int bit = 1;
            int check = ((n >> position) & bit);
            bool is1 = (check & bit) == 1;
            Console.WriteLine("The bit on position {0} has value of 1: {1}", position, is1);
        }
    }
}
