using System;
using System.IO;

/*•	Write a program that enters file name along with its full file path 
 * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
  •	Find in MSDN how to use System.IO.File.ReadAllText(…).
  •	Be sure to catch all possible exceptions and print user-friendly error messages.*/

class ReadFileContents
{
    static void Main()
    {
        Console.Write("Enter the full path of the file: ");
        string path = Console.ReadLine();
        try
        {
            string content = File.ReadAllText(path);
            Console.WriteLine("The content of the file is: ");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file '{0}' was not found!", path);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No file path is given!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The entered file path is not correct!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The chosen file is not supported!");
        }

    }
}
