using System;

class DecimalToBinary
{
    //Write a program to convert decimal numbers to their binary representation.

    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int n = int.Parse(Console.ReadLine());
        string binaryRep = null;
        while (n != 0)
        {
            binaryRep = (n % 2) + binaryRep;
            n = n / 2;
        }
        Console.WriteLine("The binary representation is: {0}", binaryRep);
    }
}
