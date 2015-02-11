using System;
using System.Threading;
using System.Globalization;

//Write a program that reads the coefficients a, b and c of a quadratic equation
//ax2 + bx + c = 0 and solves it (prints its real roots).

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Change the decimal separator to "." (to avoid an exception for ",").

            Console.Write("Enter value of a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter value of b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter value of c: ");
            double c = double.Parse(Console.ReadLine());
       
            double discriminant = (b * b) - 4 * a * c;

            if (discriminant < 0)
            {
                Console.WriteLine("There are no real roots!");
            }
            else
            {
                double discriminantRoot = Math.Sqrt(discriminant);
                double x1 = (-b - discriminantRoot) / (2 * a);
                double x2 = (-b + discriminantRoot) / (2 * a);
                Console.WriteLine(x1 == x2 ? "x1 = x2 = {0}"
                                    : "x1= {0}; x2= {1}"
                                    , x1, x2);
            }
        }
    }
}
