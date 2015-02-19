using System;

class BinaryShort
{
    //	Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

    static void Main()
    {
        Console.Write("Enter a signed short: ");
        int n = int.Parse(Console.ReadLine());
        int maxN = (int)Math.Pow(2, 15);

        while (n > maxN)
        {
            Console.WriteLine(maxN + " is the max number! Enter a signed short again:  ");
            n = int.Parse(Console.ReadLine());
        }
        bool minus = false;
        if (n < 0)
        {
            minus = true;
            n = maxN + n;
        }
        string binaryN = null;
        while (n != 0)
        {
            binaryN = (n % 2) + binaryN;
            n = n / 2;
        }
        if (minus)
        {
            Console.Write(1);
        }
        else
        {
            Console.Write(0);
        }
        Console.WriteLine("The binary representation is: {0}", binaryN.PadLeft(16, '0'));

    }
}
