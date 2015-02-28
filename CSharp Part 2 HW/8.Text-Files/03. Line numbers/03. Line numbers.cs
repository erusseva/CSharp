using System;
using System.IO;

//	Write a program that reads a text file and inserts line numbers in front of each of its lines.
//	The result should be written to another text file.

class LineNumbers
{
    static void Main()
    {
        string path = @"..\..\Input Data.txt";
        string path2 = @"..\..\Output Data.txt";
        StreamWriter writer = new StreamWriter(path2, false);
        StreamReader reader = new StreamReader(path);
        using (reader)
        {
            using (writer)
            {
                string currentLine = reader.ReadLine();
                int line = 1;
                while (currentLine != null)
                {
                    writer.WriteLine(line + ". " + currentLine);
                    currentLine = reader.ReadLine();
                    line++;
                }
            }
        }
        Console.WriteLine("The result is written in the file 'Output Data'!");
    }
}

