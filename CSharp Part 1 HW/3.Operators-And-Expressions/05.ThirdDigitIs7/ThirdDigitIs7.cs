using System;

// Write an expression that checks for given integer if its third digit from right-to-left is 7

namespace _05.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer: ");
            int intNumber = int.Parse(Console.ReadLine());

            bool check = (intNumber / 100) % 10 == 7;
            Console.WriteLine("The third digit from right-to-left is 7: " + check);
            
        }
    }
}
