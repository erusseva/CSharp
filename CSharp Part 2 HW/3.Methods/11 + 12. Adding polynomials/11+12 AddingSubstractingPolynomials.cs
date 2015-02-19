using System;

class AddingPolynomials
{
    //Write a method that adds two polynomials.Represent them as arrays of their coefficients.
    //Extend the previous program to support also subtraction and multiplication of polynomials.

    public static void Main()
    {
        int[] polinom1 = EnterPolinom();
        int[] polinom2 = EnterPolinom();
        int[] resultAddition = PolinomOperation(polinom1, polinom2, "Add");
        int[] resultSubstraction = PolinomOperation(polinom1, polinom2, "Substract");
        int[] resultMultyply = PolinomOperation(polinom1, polinom2, "Multiply");
        Console.WriteLine(" Addition");
        PrintPolinom(resultAddition);
        Console.WriteLine(" Substraction");
        PrintPolinom(resultSubstraction);
        Console.WriteLine(" Multyply");
        PrintPolinom(resultMultyply);
    }
    public static int[] EnterPolinom()
    {
        Console.Write("Enter the highest power of x : ");
        int n = int.Parse(Console.ReadLine());
        int[] answer = new int[n + 1];
        for (int i = 0; i < answer.Length; i++)
        {
            Console.Write("Enter the coefficient before x^{0} : ", i);
            answer[i] = int.Parse(Console.ReadLine());
        }
        return answer;
    }
    public static void PrintPolinom(int[] polinom)
    {
        for (int i = polinom.Length - 1; i > 0; i--)
        {
            if (polinom[i] != 0)
            {
                Console.Write("({0})x^{1} + ", polinom[i], i);
            }
        }
        Console.WriteLine("({0})", polinom[0]);
    }
    public static int[] PolinomOperation(int[] polinom1, int[] polinom2, string operation)
    {
        int[] answer;
        if (polinom1.Length >= polinom2.Length)
        {
            answer = new int[polinom1.Length];
            Array.Copy(polinom1, answer, polinom1.Length);
        }
        else
        {
            answer = new int[polinom2.Length];
            Array.Copy(polinom2, answer, polinom2.Length);
        }
        int operationsToBePerformed = Math.Min(polinom1.Length, polinom2.Length);
        if (operation == "Add")
        {
            for (int i = 0; i < operationsToBePerformed; i++)
            {
                answer[i] = polinom1[i] + polinom2[i];
            }
        }
        else if (operation == "Substract")
        {
            for (int i = 0; i < operationsToBePerformed; i++)
            {
                answer[i] = polinom1[i] - polinom2[i];
            }
        }
        else if (operation == "Multiply")
        {
            for (int i = 0; i < operationsToBePerformed; i++)
            {
                answer[i] = polinom1[i] * polinom2[i];
            }
        }
        else
        {
            Console.WriteLine("Wrong operation!");
            Environment.Exit(0);
        }
        return answer;
    }

}

