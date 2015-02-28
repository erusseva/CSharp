using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//	Write a program that reads a text file containing a list of strings, sorts them
//  and saves them to another text file.

class SaveSortedNames
{
    static void Main()
    {
        StreamReader read = new StreamReader(@"..\..\Input data.txt");
        StreamWriter write = new StreamWriter(@"..\..\Output data.txt");
        List<string> allLines = new List<string>();
        string currentLine = read.ReadLine();
        while (currentLine != null)
        {
            allLines.Add(currentLine);
            currentLine = read.ReadLine();
        }
        read.Close();
        allLines.Sort();
        foreach (string line in allLines)
        {
            write.WriteLine(line);
        }
        write.Close();
    }
}

