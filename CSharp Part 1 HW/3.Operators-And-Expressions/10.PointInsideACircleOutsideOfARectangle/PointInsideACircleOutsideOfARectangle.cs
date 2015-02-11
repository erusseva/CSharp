using System;

// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

namespace _10.PointInsideACircleOutsideOfARectangle
{
    class PointInsideACircleOutsideOfARectangle
    {
        static void Main()
        {
            double raduis = 1.5;
            Console.Write("Enter x coordinate of a point: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y coordinate of a point: ");
            double y = double.Parse(Console.ReadLine());
            bool inCircle = (Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= raduis);
            bool outRectangle = (-1 < x) ^ (x > 5) ^ (-1 < y) ^ (y > 1);
            if (inCircle && outRectangle)
            {
                Console.WriteLine("Inside K & outside of R: yes");
            }
            else
            {
                Console.WriteLine("Inside K & outside of R: no");
            }
        }
    }
}
