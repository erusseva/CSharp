using System;

// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)

namespace _07.PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            Console.WriteLine("Enter the coordinates of the point - each on a separate line!");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double point = Math.Sqrt((x * x) + (y * y));   //(x-a)2 + (y-b)2 = r2
            double radius = 2;
            bool check = point < radius;
            Console.WriteLine("The Point is inside the circle: {0}", check);
        }
    }
}
