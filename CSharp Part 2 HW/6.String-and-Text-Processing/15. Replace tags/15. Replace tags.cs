using System;

//	Write a program that replaces in a HTML document given as string all the tags
//  <a href="…">…</a> with corresponding tags [URL=…]…/URL].

class ReplaceTags
{
    static void Main()
    {
        string str = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string url = "[URL=";
        string close = "]";
        string end = "[/URL]";

        for (int i = 0; i < str.Length - 9; i++)
        {
            if (str.Substring(i, 9) == "<a href=\"")
            {
                str = str.Replace("<a href=\"", url);
            }
            if (str.Substring(i, 2) == "\">")
            {
                str = str.Replace("\">", close);
            }
            if (str.Substring(i, 4) == "</a>")
            {
                str = str.Replace("</a>", end);
            }
        }
        Console.WriteLine(str);
    }
}

