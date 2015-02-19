using System;

class NumberAsArray
{
    //Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i]contains a digit; the last digit is kept in arr[0]). 
    //Each of the numbers that will be added could have up to 10 000 digits.

    static void arrInput(int[] arr, int whichArr, int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter the {1} digit of the {0} array: ", whichArr, i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }
    static void Main()
    {
        Console.Write("Enter an integer for length of the first array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter an integer for length of the second array: ");
        int m = int.Parse(Console.ReadLine());
        int[] arr1;
        int[] arr2;
        int bigger = 0;
        if (n >= m)
        {
            arr1 = new int[n];
            arr2 = new int[n];
            bigger = n;
        }
        else
        {
            arr1 = new int[m];
            arr2 = new int[m];
            bigger = m;
        }
        arrInput(arr1, 1, n);
        arrInput(arr2, 2, m);
        int[] answer = new int[bigger + 1];
        bool carry = false;
        int curSum = 0;
        ArraySum(arr1, arr2, bigger, answer, ref carry, ref curSum);
        PrintAnswer(arr1, arr2, answer);
    }
    private static void PrintAnswer(int[] arr1, int[] arr2, int[] answer)
    {
        foreach (var digit in arr1)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
        foreach (var digit in arr2)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
        foreach (var digit in answer)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }
    private static void ArraySum(int[] arr1, int[] arr2, int bigger, int[] answer, ref bool carry, ref int curSum)
    {
        for (int i = 0; i < bigger; i++)
        {
            curSum = arr1[i] + arr2[i];
            if (curSum > 9)
            {
                if (carry)
                {
                    answer[i] = curSum - 10 + 1;
                }
                else
                {
                    answer[i] = curSum - 10;
                    carry = true;
                }
            }
            else
            {
                if (carry)
                {
                    curSum++;
                    carry = false;
                    if (curSum == 10)
                    {
                        answer[i] = 0;
                        carry = true;
                    }
                    else
                    {
                        answer[i] = curSum;
                    }
                }
                else
                {
                    answer[i] = curSum;
                }
            }
        }
        if (carry)
        {
            answer[answer.Length - 1] = 1;
        }
    }
}

