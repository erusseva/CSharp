using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.Write("Enter trapezoid's side a : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter trapezoid's side b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter trapezoid's height: ");
            double h = double.Parse(Console.ReadLine());
            double trapezoidsArea = (a + b) / 2 * h;
            Console.WriteLine("Trapezoid's area is: {0}", trapezoidsArea);
        }
    }
}
