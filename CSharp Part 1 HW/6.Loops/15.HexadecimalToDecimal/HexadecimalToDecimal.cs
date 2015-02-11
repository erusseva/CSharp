using System;

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.

namespace _15.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Enter a hexadecimal integer: ");
            string hexadecimalN = Console.ReadLine();
            long number = 0;
            long factor = 1;
            for (int i = hexadecimalN.Length - 1; i >= 0; i--)
            {
                int sign;
                switch (hexadecimalN[i])
                {
                    case 'A': sign = 10;
                        break;
                    case 'B': sign = 11;
                        break;
                    case 'C': sign = 12;
                        break;
                    case 'D': sign = 13;
                        break;
                    case 'E': sign = 14;
                        break;
                    case 'F': sign = 15;
                        break;
                    default: sign = hexadecimalN[i] - 48;
                        break;
                }
                number += sign * factor;
                factor *= 16;
            }
            Console.WriteLine("Decimal number: {0}", number);
        }
    }
}
