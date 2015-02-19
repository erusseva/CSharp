using System;

class HexadecimalToDecimal
{
    //	Write a program to convert hexadecimal numbers to their decimal representation.

    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexN = Console.ReadLine();
        int decimalN = 0;
        for (int i = 0; i < hexN.Length; i++)
        {
            switch (hexN[hexN.Length - 1 - i])
            {
                case '0': decimalN = decimalN + 0; break;
                case '1': decimalN = decimalN + 1 * (int)Math.Pow(16, i); break;
                case '2': decimalN = decimalN + 2 * (int)Math.Pow(16, i); break;
                case '3': decimalN = decimalN + 3 * (int)Math.Pow(16, i); break;
                case '4': decimalN = decimalN + 4 * (int)Math.Pow(16, i); break;
                case '5': decimalN = decimalN + 5 * (int)Math.Pow(16, i); break;
                case '6': decimalN = decimalN + 6 * (int)Math.Pow(16, i); break;
                case '7': decimalN = decimalN + 7 * (int)Math.Pow(16, i); break;
                case '8': decimalN = decimalN + 8 * (int)Math.Pow(16, i); break;
                case '9': decimalN = decimalN + 9 * (int)Math.Pow(16, i); break;
                case 'A': decimalN = decimalN + 10 * (int)Math.Pow(16, i); break;
                case 'B': decimalN = decimalN + 11 * (int)Math.Pow(16, i); break;
                case 'C': decimalN = decimalN + 12 * (int)Math.Pow(16, i); break;
                case 'D': decimalN = decimalN + 13 * (int)Math.Pow(16, i); break;
                case 'E': decimalN = decimalN + 14 * (int)Math.Pow(16, i); break;
                case 'F': decimalN = decimalN + 15 * (int)Math.Pow(16, i); break;
                default: Console.WriteLine("Invalid input !");
                    Environment.Exit(0); break;
            }
        }
        Console.WriteLine("The decimal representation is: {0}", decimalN);
    }
}

