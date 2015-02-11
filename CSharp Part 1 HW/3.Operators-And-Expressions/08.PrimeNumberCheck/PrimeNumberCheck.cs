using System;

// Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer <= 100");
            int intnumber = int.Parse(Console.ReadLine());
            bool checkIsPrime = true;
            if (intnumber <= 0 || intnumber >= 100)
            {
                checkIsPrime = false;
                Console.WriteLine("Invalid value - enter an integer <= 100 !");
            }
            else if (intnumber == 1)
            {
                checkIsPrime = false;
                Console.WriteLine("The number is prime: {0}", checkIsPrime);
            }
            else
            {
                for (int intNumber2 = 2; intNumber2 < intnumber; intNumber2++)
                {
                    if (intnumber % intNumber2 == 0)
                    {
                        checkIsPrime = false;
                        Console.WriteLine("The number is prime: {0}", checkIsPrime);
                        return;
                    }
                }
                checkIsPrime = true;
                Console.WriteLine("The number is prime: {0}", checkIsPrime);
            }

        }
    }
}
