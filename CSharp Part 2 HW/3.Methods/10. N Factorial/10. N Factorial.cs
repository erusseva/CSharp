using System;

class NFactorial
{
    //Write a program to calculate n! for each n in the range [1..100].

    public static string NumberMultiplyer(string number, int digit)
    {
        string result = null;
        int step = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            int currentDigit = int.Parse(number[i].ToString());
            int currentProduct = currentDigit * digit;
            if (currentProduct + step < 10)
            {
                result = (currentProduct + step) + result;
            }
            else
            {
                result = ((currentProduct + step) % 10) + result;
                step = (currentProduct + step) / 10;
            }
        }
        if (step != 0)
        {
            result = step + result;
        }
        return result;
    }
    public static void Main()
    {
        Console.Write("Enter a positive integer [1..100]: ");
        int n = int.Parse(Console.ReadLine());
        string answer = "1";
        for (int i = 2; i <= n; i++)
        {
            answer = NumberMultiplyer(answer, i);
        }
        Console.WriteLine("{0}! = {1}", n, answer);
    }
}

