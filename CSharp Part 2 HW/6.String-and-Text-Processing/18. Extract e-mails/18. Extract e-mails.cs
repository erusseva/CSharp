using System;
using System.Text;
using System.Text.RegularExpressions;

//	Write a program for extracting all email addresses from given text.
//	All sub-strings that match the format @… should be recognized as emails.

class ExtractEMails
{
    static void Main()
    {
        //Console.WriteLine("Enter a text: ");
        //string str = Console.ReadLine();
        //For easy tetsting:
        string str = "She has 3 mail adresses: blabla@mail.bg is the main, but she use mail@abv.bg as well, and usualy forget the third one - example@gmail.com";
        foreach (var mail in Regex.Matches(str, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(mail);
        }
    }
}

