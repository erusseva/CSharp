using System;

class AppearanceCount
{
    //Write a method that counts how many times given number appears in given array.
    //Write a test program to check if the method is workings correctly.

    static int Counter(int number, params int[] array)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
    static int[] ArrayReader()
    {
        Console.Write("Enter an integer for length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the {0} element: ", (i + 1));
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] array = ArrayReader();
        int counter = Counter(number, array);
        Console.WriteLine("That number appears {0} times in entered array.", counter);
    }
}
