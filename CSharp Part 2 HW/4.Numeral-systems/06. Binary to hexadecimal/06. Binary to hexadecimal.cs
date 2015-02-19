using System;
using System.Numerics;

class BinaryToHexadecimal
{
    //Write a program to convert binary numbers to hexadecimal numbers (directly).

    static void Main()
    {
        Console.Write("Enter a binary number: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        string hexN = "";
        int power = 0;
        while (true)
        {
            if (n > 0)
            {
                BigInteger remainder = (BigInteger)n % 10000;
                n /= 10000;
                int sum = 0;
                for (int i = 1; i <= 4; i++)
                {
                    BigInteger currentRemainder = (BigInteger)remainder % 10;
                    remainder /= 10;
                    sum = sum + (int)currentRemainder * (int)Math.Pow(2, power);
                    power++;
                }
                if (sum <= 9)
                {
                    hexN = sum + hexN;
                }
                else
                {
                    if (sum == 10) hexN = "A" + hexN;
                    if (sum == 11) hexN = "B" + hexN;
                    if (sum == 12) hexN = "C" + hexN;
                    if (sum == 13) hexN = "D" + hexN;
                    if (sum == 14) hexN = "E" + hexN;
                    if (sum == 15) hexN = "F" + hexN;
                }
                power = 0;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("The hexadecimal representation is: {0}", hexN);
    }
}

