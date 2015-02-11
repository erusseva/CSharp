using System;

//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.

namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int thirdNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            int fourthNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the fifth number: ");
            
            int fifthNumber = Int32.Parse(Console.ReadLine());
            bool hasSubset = false;
            
            string result = "Result: {0} + {1} = 0";
            string result2 = "Result: {0} + {1} + {2} = 0";
            string result3 = "Result: {0} + {1} + {2} + {3} = 0";
            string result4 = "Result: {0} + {1} + {2} + {3} + {4} = 0";

            if (firstNumber + secondNumber == 0)
            {
                Console.WriteLine(result, firstNumber, secondNumber);
                hasSubset = true;
            }
            if (firstNumber + thirdNumber == 0)
            {
                Console.WriteLine(result, firstNumber, thirdNumber);
                hasSubset = true;
            }
            if (firstNumber + fourthNumber == 0)
            {
                Console.WriteLine(result, firstNumber, fourthNumber);
                hasSubset = true;
            }
            if (firstNumber + fifthNumber == 0)
            {
                Console.WriteLine(result, firstNumber, fifthNumber);
                hasSubset = true;
            }
            if (secondNumber + thirdNumber == 0)
            {
                Console.WriteLine(result, secondNumber, thirdNumber);
                hasSubset = true;
            }
            if (secondNumber + fourthNumber == 0)
            {
                Console.WriteLine(result, secondNumber, fourthNumber);
                hasSubset = true;
            }
            if (secondNumber + fifthNumber == 0)
            {
                Console.WriteLine(result, secondNumber, fifthNumber);
                hasSubset = true;
            }
            if (thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine(result, thirdNumber, fourthNumber);
                hasSubset = true;
            }
            if (thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine(result, thirdNumber, fifthNumber);
                hasSubset = true;
            }
            if (fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine(result, fourthNumber, fifthNumber);
                hasSubset = true;
            }
            if (firstNumber + secondNumber + thirdNumber == 0)
            {
                Console.WriteLine(result2, firstNumber, secondNumber, thirdNumber);
                hasSubset = true;
            }
            if (firstNumber + secondNumber + fourthNumber == 0)
            {
                Console.WriteLine(result2, firstNumber, secondNumber, fourthNumber);
                hasSubset = true;
            }
            if (firstNumber + secondNumber + fifthNumber == 0)
            {
                Console.WriteLine(result2, firstNumber, secondNumber, fifthNumber);
                hasSubset = true;
            }
            if (firstNumber + thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine(result2, firstNumber, thirdNumber, fourthNumber);
                hasSubset = true;
            }
            if (firstNumber + thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine(result2, firstNumber, thirdNumber, fifthNumber);
                hasSubset = true;
            }
            if (firstNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine(result2, firstNumber, fourthNumber, fifthNumber);
                hasSubset = true;
            }
            if (secondNumber + thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine(result2, secondNumber, thirdNumber, fourthNumber);
                hasSubset = true;
            }
            if (secondNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine(result2, secondNumber, fourthNumber, fifthNumber);
                hasSubset = true;
            }
            if (secondNumber + thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine(result2, secondNumber, thirdNumber, fifthNumber);
                hasSubset = true;
            }
            if (thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine(result2, thirdNumber, fourthNumber, fifthNumber);
                hasSubset = true;
            }
            if (firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine(result3, firstNumber, secondNumber, thirdNumber, fourthNumber);
                hasSubset = true;
            }
            if (firstNumber + secondNumber + thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine(result3, firstNumber, secondNumber, thirdNumber, fifthNumber);
                hasSubset = true;
            }
            if (firstNumber + secondNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine(result3, firstNumber, secondNumber, fourthNumber, fifthNumber);
                hasSubset = true;
            }
            if (firstNumber + thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine(result3, firstNumber, thirdNumber, fourthNumber, fifthNumber);
                hasSubset = true;
            }
            if (secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine(result3, secondNumber, thirdNumber, fourthNumber, fifthNumber);
                hasSubset = true;
            }
            if (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine(result4, firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
                hasSubset = true;
            }
            if (!hasSubset)
            {
                Console.WriteLine("No zero subset!");
            }

        }
    }
}
