using System;
using System.Text;

class SolveTasks
{
    /*•	Write a program that can solve these tasks:
        o	Reverses the digits of a number
        o	Calculates the average of a sequence of integers
        o	Solves a linear equation a * x + b = 0
      •	Create appropriate methods.
      •	Provide a simple text-based menu for the user to choose which task to solve.
      •	Validate the input data:
        o	The decimal number should be non-negative
        o	The sequence should not be empty
        o	a should not be equal to 0*/

    public static void Main()
    {
        int n = ChooseTaskToSolve();
        if (n == 1)
        {
            SolveTask1();
        }
        else if (n == 2)
        {
            SolveTask2();
        }
        else
        {
            SolveTask3();
        }
    }
    private static int ChooseTaskToSolve()
    {
        Console.WriteLine("Choose the task for solve: ");
        Console.WriteLine("# enter \"1\" for reversing the digits of a number");
        Console.WriteLine("# enter \"2\" for calculating the average of sequence of integers");
        Console.WriteLine("# enter \"3\" for solving a linear equation a * x + b = 0");
        int n = 0;
        do
        {
            int.TryParse(Console.ReadLine(), out n);
        }
        while (n != 1 && n != 2 && n != 3);
        return n;
    }

    public static void SolveTask1()
    {
        Console.Write("Enter the number: ");
        string number = Console.ReadLine().Trim();
        while (number[0] == '-')
        {
            Console.Write("It can not be negative! Enter the number again: ");
            number = Console.ReadLine().Trim();
        }
        StringBuilder answer = new StringBuilder();
        for (int i = number.Length - 1; i >= 0; i--)
        {
            answer.Append(number[i]);
        }
        Console.WriteLine("The result is {0}", answer.ToString());
    }
    public static void SolveTask2()
    {
        Console.Write("Enter the number of integers: ");
        double n = int.Parse(Console.ReadLine());
        while (n == 0)
        {
            Console.Write("The integers should not be 0 ! Enter the number of integers again: ");
            n = int.Parse(Console.ReadLine());
        }
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the {0} integer : ", i + 1);
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The result is {0}", sum / n);
    }

    public static void SolveTask3()
    {
        Console.Write("Enter coefficient before x : ");
        double x = double.Parse(Console.ReadLine());
        while (x == 0)
        {
            Console.WriteLine("The coefficient before x can not be 0 ! Enter it again: ");
            x = double.Parse(Console.ReadLine());
        }
        Console.Write("Enter the free coefficient : ");
        double free = double.Parse(Console.ReadLine());
        double answer = (free * (-1)) / x;
        Console.WriteLine("The answer is: {0}", answer);
    }
}

