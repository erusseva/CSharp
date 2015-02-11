using System;
using System.Threading;
using System.Globalization;

//Write a program that reads 3 numbers: integer a (0 <= a <= 500), floating-point b, floating-point c.
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

namespace _5.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Change the decimal separator to "." (to avoid an exception for ",").

            Console.Write("Enter an integer A (0 <= A <= 500): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a floating-point number B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter a floating-point number C: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:F3}|"
                        , a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}
