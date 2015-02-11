using System;

// Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.

namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter a binary integer: ");
            string binaryN = Console.ReadLine();
            long decimalN = 0;
            int factor = 1;
            for (int i = binaryN.Length - 1; i >= 0; i--)
            {
                int sign = binaryN[i] - 48;
                if (sign == 1)
                {
                    decimalN += sign * factor;
                }
                factor *= 2;
            }
            Console.WriteLine("Decimal number: {0}", decimalN);
        }
    }
}
