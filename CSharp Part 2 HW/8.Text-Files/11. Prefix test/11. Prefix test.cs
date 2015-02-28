using System;
using System.IO;
using System.Collections.Generic;

//	Write a program that deletes from a text file all words that start with the prefix test.
//	Words contain only the symbols 0…9, a…z, A…Z, _.

class PrefixTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Input data.txt");
        List<string> answer = new List<string>();
        string currentLine = reader.ReadLine();
        while (currentLine != null)
        {
            int index = currentLine.IndexOf("Test");
            if (index != -1)
            {
                if ((currentLine[index + 4] != ' ') && (currentLine[index + 4] != '.') && (currentLine[index + 4] != ',') && (currentLine[index + 4] != '-'))
                {
                    currentLine = currentLine.Substring(0, index) + currentLine.Substring(index + 4);
                }
            }
            index = -1;
            index = currentLine.IndexOf("test");
            if (index != -1)
            {
                if ((currentLine[index + 4] != ' ') && (currentLine[index + 4] != '.') && (currentLine[index + 4] != ',') && (currentLine[index + 4] != '-'))
                {
                    currentLine = currentLine.Substring(0, index) + currentLine.Substring(index + 4);
                }
            }
            answer.Add(currentLine);
            currentLine = reader.ReadLine();
        }
        reader.Close();
        StreamWriter writer = new StreamWriter(@"..\..\Input data.txt", false);
        foreach (string item in answer)
        {
            writer.WriteLine(item);
        }
        writer.Close();

    }
}

