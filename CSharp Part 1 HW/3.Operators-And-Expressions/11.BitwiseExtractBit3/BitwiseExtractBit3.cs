using System;

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

namespace _11.BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.Write("Please enter an unsigned integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation of the number {0} is: {1}"
            , number, Convert.ToString(number, 2).PadLeft(16, '0'));
            int position = 3;
            int bitCheck = 1 << position;
            Console.WriteLine((number & bitCheck) == bitCheck ?
            "The third bit is: 1 " : "The value of the third bit is: 0");
        }
    }
}
