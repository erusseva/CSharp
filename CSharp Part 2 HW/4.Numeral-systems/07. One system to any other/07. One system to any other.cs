using System;
using System.Text;

class OneSystemToAnyOther
{
    //	Write a program to convert from any numeral system of given base s to any other 
    //  numeral system of base d (2 ≤s, d ≤ 16).

    static void Main()
    {
        Console.Write("Enter an integer in the range [2:16] to choose numeral system: ");
        int numeralSystem = int.Parse(Console.ReadLine());
        Console.Write("Enter a number in {0}-based numberal system: ", numeralSystem);
        long n = Math.Abs(long.Parse(Console.ReadLine()));
        Console.WriteLine("Enter an integer in the range [2:16] to choose numeral system into which you want to convert: ");
        int numeralSystemConv = int.Parse(Console.ReadLine());
        long number = n;
        long decimalN = 0;
        int power = 0;
        while (number > 0)
        {
            int digit = (int)number % 10;
            digit *= (int)Math.Pow(numeralSystem, (double)power);
            decimalN += digit;
            power++;
            number /= 10;
        }
        StringBuilder str = new StringBuilder();
        while (decimalN > 0)
        {
            str.Insert(0, decimalN % numeralSystemConv);
            decimalN /= numeralSystemConv;
        }
        Console.WriteLine("The number {0} in {1}-based numeral system is {2} in {3}-based numeral system"
        , n, numeralSystem, str.ToString(), numeralSystemConv);
    }
}

