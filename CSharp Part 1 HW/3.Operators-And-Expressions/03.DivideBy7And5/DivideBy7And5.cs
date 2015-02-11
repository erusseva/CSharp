using System;

// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

namespace _03.DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer: ");
            int intNumber = int.Parse(Console.ReadLine());

            bool check = (intNumber % 35 == 0) && (intNumber !=0);

            Console.WriteLine("{0} can be divided (without remainder) by 7 and 5 at the same time: {1}",
                intNumber, check);

        }
    }
}
