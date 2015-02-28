using System;
using System.Text;

//	Write a program that extracts from given HTML file its title (if available), 
//  and its body text without the HTML tags.

class ExtractTextFromHTML
{
    static void Main()
    {
        //Console.WriteLine("Enter a string: ");
        //string str = Console.ReadLine();
        //Just for easy tetsting:
        string str = @"<html>
  <head><title>News</title></head>
  <body><p><a href=""http://academy.telerik.com"">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>";
        StringBuilder clean = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '<')
            {
                while (str[i] != '>')
                {
                    i++;
                }
                continue;
            }
            clean.Append(str[i]);
        }
        Console.WriteLine(clean.ToString().Trim());
        Console.WriteLine();
    }
}

