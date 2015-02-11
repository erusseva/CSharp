using System;
using System.Text;

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.

namespace _14.DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main()
        {
            Console.Write("Enter an integer (>= 0): ");
            long decimalN = long.Parse(Console.ReadLine());
            long remainder;
            StringBuilder binaryN = new StringBuilder();
            while (decimalN > 0)
            {
                int index = 0;
                remainder = decimalN % 2;
                binaryN.Insert(index, remainder);
                decimalN /= 2;
                index++;
            }
            Console.WriteLine("Binary number: {0}", binaryN);
        }
    }
}
