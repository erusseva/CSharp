using System;
using System.Linq;

//	Write a program to check if in a given expression the brackets are put correctly.

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter an expression: ");
        string exp = Console.ReadLine();
        if (BracketsArePutCorrectly(exp))
        {
            Console.WriteLine("The brackets are put correctly !");
        }
        else
        {
            Console.WriteLine("The brackets are NOT put correctly !");
        }
    }

    private static bool BracketsArePutCorrectly(string exp)
    {
        int bracketCount = 0;
        foreach (var symbol in exp)
        {
            if (symbol == '(') bracketCount++;
            else if (symbol == ')') bracketCount--;

            if (bracketCount < 0)
                return false;
        }
        return bracketCount == 0;
    }

}

