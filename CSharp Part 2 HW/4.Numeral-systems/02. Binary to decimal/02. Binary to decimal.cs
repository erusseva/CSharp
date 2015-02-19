using System;

class BinaryToDecimal
{
    //Write a program to convert binary numbers to their decimal representation.
    
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string n = Console.ReadLine();
        int binaryN = 0;
        for (int i = 0; i < n.Length; i++)
        {
            binaryN = binaryN * 2;
            if (n[i] == '1')
                binaryN = binaryN + 1;
        }
        Console.WriteLine("The decimal representation is: {0}", binaryN);
    }
}

