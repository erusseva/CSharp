using System;

class LargerThanNeighbours
{
    //Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
    static void arrayInput(int size, int[] array)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter the {0} element: ", (i + 1));
            array[i] = int.Parse(Console.ReadLine());
        }
    }
    static void Main()
    {
        Console.Write("Enter an integer for length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        arrayInput(n, array);
        Console.Write("Enter the position of the element - from 1 to {0} ", n);
        int elementPos = int.Parse(Console.ReadLine());
        ElementCompararer(n, array, elementPos);
    }
    private static void ElementCompararer(int n, int[] array, int elementPos)
    {
        if ((elementPos == 1) || (elementPos == n))
        {
            Console.WriteLine("The element on position {0} doesn't have two neighbours", elementPos);
        }
        else
        {
            if ((array[elementPos - 1] > array[elementPos]) && (array[elementPos - 1] < array[elementPos - 2]))
            {
                Console.WriteLine("Yes - the element on position {0} is {1} and it is bigger than it's two neighbours - {2} and {3}", elementPos, array[elementPos - 1], array[elementPos - 2], array[elementPos]);
            }
            else
            {
                Console.WriteLine("No - the element on position {0} is {1} and it isn't bigger than it's two neighbours - {2} and {3}", elementPos, array[elementPos - 1], array[elementPos - 2], array[elementPos]);
            }
        }
    }
}

