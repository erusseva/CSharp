using System;
using System.Threading;
using System.Globalization;

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
//As a result print the values a and b, separated by a space.

namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Change the decimal separator to "." (to avoid an exception for ",").

            Console.Write("Enter the first variable: ");
            double firstVariable = double.Parse(Console.ReadLine());
            Console.Write("Enter the second variable: ");
            double secondVariable = double.Parse(Console.ReadLine());
            double exchange = 0;
            if (firstVariable > secondVariable)
            {
                exchange = firstVariable;
                firstVariable = secondVariable;
                secondVariable = exchange;
            }
            Console.WriteLine("{0} {1}", firstVariable, secondVariable);
        }
    }
}
