using System;

//	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.


class Palindromes
{
    static void Main()
    {
        //Console.WriteLine("Enter a text: ");
        //string str = Console.ReadLine();
        //For easy tetsting:
        string str = "I don't listen ABBA, I bet you don't have an idea what is a lamal and for sure we all know what exe is using for.";
        string[] words = str.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            bool isPalindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if ((isPalindrome) && (word.Length > 1)) 
            {
                Console.WriteLine(word);
            }
        }
    }
}
