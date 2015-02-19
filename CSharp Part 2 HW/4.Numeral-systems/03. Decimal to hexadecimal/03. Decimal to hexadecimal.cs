using System;

class DecimalToHexadecimal
{       //Write a program to convert decimal numbers to their hexadecimal representation.
   
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int n = int.Parse(Console.ReadLine());
        string hexRep = null;
        bool negative = false;
        if (n < 0)
        {
            n = n * (-1);
            negative = true;
        }
        while (n != 0)
        {
            if (n % 16 > 9)
            {
                switch (n % 16)
                {
                    case 10: hexRep = "A" + hexRep; break;
                    case 11: hexRep = "B" + hexRep; break;
                    case 12: hexRep = "C" + hexRep; break;
                    case 13: hexRep = "D" + hexRep; break;
                    case 14: hexRep = "E" + hexRep; break;
                    case 15: hexRep = "F" + hexRep; break;
                }
            }
            else
            {
                hexRep = n % 16 + hexRep;
            }
            n = n / 16;
        }
        if (negative)
        {
            Console.Write("Negative ");
        }
        Console.Write("The hexadecimal representation is: {0}", hexRep);
        Console.WriteLine();
    }
}

