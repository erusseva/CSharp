using System;

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.Write("Enter an integers in a single line, separated by a space: ");
            string strNumbers = Console.ReadLine();
            string[] Numbers = strNumbers.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);
            int oddProduct = 1;
            int evenProduct = 1;
            for (int i = 0; i < Numbers.Length; i++)
            {
                int currentNumber = int.Parse(Numbers[i]);
                if (i % 2 == 0)
                {
                    evenProduct *= currentNumber;
                }
                else if (i % 2 != 0)
                {
                    oddProduct *= currentNumber;
                }
            }
            bool equalProducts = oddProduct == evenProduct;
            Console.WriteLine(equalProducts ? "Yes!\nproduct = {0}" : "No!\nodd_product = {0}\neven_product = {1}"
            , oddProduct, evenProduct);
        }
    }
}
