using System;
using System.IO;

//	Write a program that concatenates two text files into another text file.

class ConcatenateTextFiles
{
    static void Main()
    {
        using (StreamWriter write = new StreamWriter(@"..\..\Concatenated files.txt", true))
        {
            using (StreamReader firstReader = new StreamReader(@"..\..\Input Data 1.txt"))
            {
                string line = firstReader.ReadLine();
                while (line != null)
                {
                    write.WriteLine(line);
                    line = firstReader.ReadLine();
                }
            }
            using (StreamReader secondReader = new StreamReader(@"..\..\Input Data 2.txt"))
            {
                string line = secondReader.ReadLine();
                while (line != null)
                {
                    write.WriteLine(line);
                    line = secondReader.ReadLine();
                }
            }
        }
        Console.WriteLine("Concatenation of the files is done!");
    }
}
