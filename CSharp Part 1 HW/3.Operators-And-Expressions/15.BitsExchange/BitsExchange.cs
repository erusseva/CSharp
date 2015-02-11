using System;

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            Console.Write("Enter an unsigned integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation of number {0} is: \n{1}",
            number, Convert.ToString(number, 2).PadLeft(32, '0'));
            
            int mask = 1 << 3;
            int thirdBit = (number & mask) >> 3;
            mask = 1 << 24;
            int twentyFourthBit = (number & mask) >> 24;
            mask = 1 << 4;
            int fourthBit = (number & mask) >> 4;
            mask = 1 << 25;
            int twentyFifthBit = (number & mask) >> 25;
            mask = 1 << 5;
            int fifthBit = (number & mask) >> 5;
            mask = 1 << 26;
            int twentySixthBit = (number & mask) >> 26;
            if (((thirdBit == twentyFourthBit) && (fourthBit == twentyFifthBit)) && (fifthBit == twentySixthBit))
            {
                Console.WriteLine("Result after exchange: {0}", number);
                Console.WriteLine("Binary result after exchange:\n{0}", 
                Convert.ToString(number, 2).PadLeft(32, '0'));
                return;
            }
            if (thirdBit == 0)
            {
                mask = ~(1 << 24);
                number = number & mask;
            }
            else if (thirdBit == 1)
            {
                mask = 1 << 24;
                number = number | mask;
            }
            if (twentyFourthBit == 0)
            {
                mask = ~(1 << 3);
                number = number & mask;
            }
            else if (twentyFourthBit == 1)
            {
                mask = 1 << 3;
                number = number | mask;
            }
            if (fourthBit == 0)
            {
                mask = ~(1 << 25);
                number = number & mask;
            }
            else if (fourthBit == 1)
            {
                mask = 1 << 25;
                number = number | mask;
            }
            if (twentyFifthBit == 0)
            {
                mask = ~(1 << 4);
                number = number & mask;
            }
            else if (twentyFifthBit == 1)
            {
                mask = 1 << 4;
                number = number | mask;
            }
            if (fifthBit == 0)
            {
                mask = ~(1 << 26);
                number = number & mask;
            }
            else if (fifthBit == 1)
            {
                mask = 1 << 26;
                number = number | mask;
            }
            if (twentySixthBit == 0)
            {
                mask = ~(1 << 5);
                number = number & mask;
            }
            else if (twentySixthBit == 1)
            {
                mask = 1 << 5;
                number = number | mask;
            }
            Console.WriteLine("Result after exchange: {0}", number);
            Console.WriteLine("Binary result after exchange:\n{0}", 
            Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}
