using System;

// Write an expression that calculates rectangle’s perimeter and area by given width and height.

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Enter the width of a rectangle");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of a rectangle");
            double height = double.Parse(Console.ReadLine());

            double perimeter = (width + height) * 2;
            double area = width * height;
            Console.WriteLine("The rectangle’s perimeter is {0}\nThe rectangle area is {1}"
            , perimeter, area);
        }
    }
}
