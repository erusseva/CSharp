using System;

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
  // Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
  // Prints on the console the number in reversed order: dcba (in our example 1102).
  // Puts the last digit in the first position: dabc (in our example 1201).
  // Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a foor-digit integer: ");
            int intnumber = int.Parse(Console.ReadLine());
            int d = intnumber % 10;
            intnumber = intnumber / 10;
            int c = intnumber % 10;
            intnumber = intnumber / 10;
            int b = intnumber % 10;
            intnumber = intnumber / 10;
            int a = intnumber % 10;
            int sum = a + b + c + d;
            Console.WriteLine("Sum of digits: {0}", sum);
            Console.WriteLine("Reversed digits: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit in the first position: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", a, c, b, d);
        }
    }
}
