using System;
using System.Text;

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.

namespace _16.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter an integer (>= 0): ");
            long decimalN = long.Parse(Console.ReadLine());
            StringBuilder binaryN = new StringBuilder();
            while (decimalN > 0)
            {
                int index = 0;
                char hexValue = '0';
                long remainder = decimalN % 16;
                if (remainder > 9)
                {
                    switch (remainder)
                    {
                        case 10: hexValue = 'A';
                            break;
                        case 11: hexValue = 'B';
                            break;
                        case 12: hexValue = 'C';
                            break;
                        case 13: hexValue = 'D';
                            break;
                        case 14: hexValue = 'E';
                            break;
                        case 15: hexValue = 'F';
                            break;
                        default: Console.WriteLine("Invalid input!");
                            break;
                    }
                    binaryN.Insert(index, hexValue);
                }
                else
                {
                    binaryN.Insert(index, remainder);
                }
                decimalN /= 16;
                index++;
            }
            Console.WriteLine("Hexadecimal number: {0}", binaryN);
        }
    }
}
