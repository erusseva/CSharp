using System;
using System.Text;

class HexadecimalToBinary
{
    //Write a program to convert hexadecimal numbers to binary numbers (directly).

    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string n = Console.ReadLine();
        StringBuilder binaryN = new StringBuilder();
        foreach (char letter in n)
        {
            switch (letter)
            {
                case '0': binaryN.Append("0000 "); break;
                case '1': binaryN.Append("0001 "); break;
                case '2': binaryN.Append("0010 "); break;
                case '3': binaryN.Append("0011 "); break;
                case '4': binaryN.Append("0100 "); break;
                case '5': binaryN.Append("0101 "); break;
                case '6': binaryN.Append("0110 "); break;
                case '7': binaryN.Append("0111 "); break;
                case '8': binaryN.Append("1000 "); break;
                case '9': binaryN.Append("1001 "); break;
                case 'A': binaryN.Append("1010 "); break;
                case 'B': binaryN.Append("1011 "); break;
                case 'C': binaryN.Append("1100 "); break;
                case 'D': binaryN.Append("1101 "); break;
                case 'E': binaryN.Append("1110 "); break;
                case 'F': binaryN.Append("1111 "); break;
                default: Console.WriteLine("Invalid input !"); break;
            }
        }
        Console.WriteLine("The binary representation is: {0}", binaryN);
    }
}

