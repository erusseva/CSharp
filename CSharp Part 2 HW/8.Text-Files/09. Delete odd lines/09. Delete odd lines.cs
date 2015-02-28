using System;
using System.IO;
using System.Collections.Generic;

//	Write a program that deletes from given text file all odd lines.
//	The result should be in the same file.

class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Data.txt");
        List<string> allEvenLines = new List<string>();
        string currentLine = null;
        while (1 == 1)
        {
            currentLine = reader.ReadLine();
            currentLine = reader.ReadLine();
            if (currentLine == null)
            {
                break;
            }
            allEvenLines.Add(currentLine);
        }
        reader.Close();
        StreamWriter writer = new StreamWriter(@"..\..\Data.txt", false);
        foreach (string line in allEvenLines)
        {
            writer.WriteLine(line);
        }
        writer.Close();

    }
}

