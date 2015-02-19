using System;
using System.Globalization;
using System.Threading;

class BinaryFloatingPoint
{
    //	Write a program that shows the internal binary representation of given 32-bit signed 
    //  floating-point number in IEEE 754 format (the C# type float).

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter a floating-point number: ");
        float n = float.Parse(Console.ReadLine());
        int sign = n > 0 ? 0 : 1;
        n = Math.Abs(n);
        string inBinary = Converter(n);
        if ((int)n == 0 || (int)n == 1)
        {
            inBinary = "0" + inBinary;
        }
        Console.WriteLine("Sign: {0}; Exponent: {1}; Mantissa: {2};", sign, GetExponent(inBinary), GetMantissa(inBinary));
    }

    static string Converter(float number)
    {
        int intN = BitConverter.ToInt32(BitConverter.GetBytes(number), 0);
        return Convert.ToString(intN, 2);
    }
    static string GetExponent(string inBinary)
    {
        return inBinary.Substring(0, 8);
    }
    static string GetMantissa(string inBinary)
    {
        return inBinary.Substring(8);
    }
}

