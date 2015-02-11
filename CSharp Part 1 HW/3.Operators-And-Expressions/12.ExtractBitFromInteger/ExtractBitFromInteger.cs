using System;

//Write an expression that extracts from given integer n the value of given bit at index p.

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Enter an unsigned integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter a bit's position: ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation of the number {0} is: {1}",
            number, Convert.ToString(number, 2).PadLeft(16, '0'));
            
            // The bits are counted from right to left, starting from bit #0.
            int bitCheck = 1 << position;
            Console.WriteLine((number & bitCheck) == bitCheck ?
            "The bit in position {0} is: 1 " :
            "The bit in position {0} is: 0"
            , position);
        }
    }
}
