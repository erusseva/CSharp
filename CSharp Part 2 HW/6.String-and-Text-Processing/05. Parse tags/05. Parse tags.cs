using System;
using System.Linq;
using System.Text;

//	You are given a text. Write a program that changes the text in all regions surrounded by 
//the tags <upcase> and</upcase> to upper-case.

class ParseTags
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        StringBuilder strB = new StringBuilder();
        int toUpper = -1;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '<')
            {
                i++;
                toUpper = toUpper * (-1);
                while (str[i] != '>')
                {
                    i++;
                }
            }
            else
            {
                if (toUpper == 1)
                {
                    strB.Append(str[i].ToString().ToUpper());
                }                                             
                else
                {
                    strB.Append(str[i]);
                }
                
            }
        }
        Console.WriteLine(strB.ToString());
    }
}

