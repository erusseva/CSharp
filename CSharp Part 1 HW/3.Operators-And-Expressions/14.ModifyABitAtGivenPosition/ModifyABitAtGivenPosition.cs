using System;

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p
//from the binary representation of n while preserving all other bits in n.

namespace _14.ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter an unsigned integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation of the number {0} is: {1}",
            number, Convert.ToString(number, 2).PadLeft(16, '0'));
            
            Console.Write("Enter a bit's position: ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Enter a bit value (0 or 1): ");
            int bitValue = int.Parse(Console.ReadLine());
            
            int modifier = 1 << position;
            if (bitValue == 0)
            {
                number = number & (~modifier);
                Console.WriteLine("The binary result is: {0}\nand the number (result) is: {1}",
                Convert.ToString(number, 2).PadLeft(16, '0'), number);
            }
            else
            {
                number = number | modifier;
                Console.WriteLine("The binary result is: {0}\nand the number (result) is: {1}",
                Convert.ToString(number, 2).PadLeft(16, '0'), number);
            }
        }
    }
}
