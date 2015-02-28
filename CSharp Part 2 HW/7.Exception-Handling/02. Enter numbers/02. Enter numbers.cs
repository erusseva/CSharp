using System;

/*•	Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
    o	If an invalid number or non-number text is entered, the method should throw an exception.
  •	Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/

class EnterNumbers
{
    public static void ReadNumber(int[] arr, int n)
    {
        Console.Write("Enter a{0}: ", n + 1);
        try
        {
            arr[n] = int.Parse(Console.ReadLine());
        }
        catch (FormatException FE)
        {
            throw new FormatException("Invalid Number! " + FE);
        }
        if (n == 0)
        {
            if (arr[n] <= 1)
            {
                throw new Exception("The first number should be bigger than 1!");
            }
        }
        else if (n == 9)
        {
            if (arr[n] > +100)
            {
                throw new Exception("The last number should be smaller than 100!");
            }
        }
        else
        {
            if (arr[n] < arr[n - 1])
            {
                throw new Exception("The number should be bigger than the previous one!");
            }
        }
    }
    public static void Main()
    {
        int[] arrA = new int[10];
        for (int i = 0; i < 10; i++)
        {
            ReadNumber(arrA, i);
        }
    }
}
