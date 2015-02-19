using System;

class FirstLargerThanNeighbours
{
   //Write a method that returns the index of the first element in array that is larger than
 // its neighbours, or -1, if there’s no such element. Use the method from the previous exercise.
    
    public static int[] arrayInput()
    {
        Console.Write("Enter an integer for length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the {0} element: ", (i + 1));
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
    public static void ElementCompararer(int[] array, int elementPos)
    {
        if ((array[elementPos - 1] < array[elementPos]) && (array[elementPos + 1] < array[elementPos]))
        {
            Console.WriteLine("The element on position {0} is {1} and it is bigger than it's two neighbours - {2} and {3}", elementPos, array[elementPos], array[elementPos - 1], array[elementPos + 1]);
            Environment.Exit(0);
        }
    }
    public static void Main()
    {
        int[] array = arrayInput();
        for (int i = 1; i < array.Length - 1; i++)
        {
            ElementCompararer(array, i);
        }
        Console.WriteLine(-1);
    }
}
