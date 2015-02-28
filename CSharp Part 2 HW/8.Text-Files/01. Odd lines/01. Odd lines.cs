using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

//	Write a program that reads a text file and prints on the console its odd lines.

class OddLines
{
    static void Main()
    {
        int currentLine = 0;
        using (StreamReader reader = new StreamReader(@"..\..\Input data.txt"))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                currentLine++;
                if (currentLine % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
            }
        }
    }
}

