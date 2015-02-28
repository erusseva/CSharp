using System;
using System.IO;

// Write a program that compares two text files line by line and prints the number of
// lines that are the same and the number of lines that are different.
// Assume the files have equal number of lines.

class CompareTextFiles
{
    static void Main()
    {
        string path = @"..\..\Input data 1.txt";
        string path2 = @"..\..\Input data 2.txt";
        StreamReader reader1 = new StreamReader(path);
        StreamReader reader2 = new StreamReader(path2);
        int sameLines = 0;
        int differentLines = 0;
        string line1 = reader1.ReadLine();
        string line2 = reader2.ReadLine();
        while (line1 != null)
        {
            if (line1 == line2)
            {
                sameLines++;
            }
            else
            {
                differentLines++;
            }
            line1 = reader1.ReadLine();
            line2 = reader2.ReadLine();
        }
        Console.WriteLine("Same lines: {0}", sameLines);
        Console.WriteLine("Different lines: {0}", differentLines);

    }
}

