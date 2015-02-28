using System;

class TriangleSurface
{
    /*•	Write methods that calculate the surface of a triangle by given:
    o	Side and an altitude to it;
    o	Three sides;
    o	Two sides and an angle between them;
  •	Use System.Math.*/

    static void Main()
    {
        Console.Write("Enter the side of a triangle: ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Enter the altitude of a triangle: ");
        double alt = double.Parse(Console.ReadLine());
        Console.WriteLine("The surface of this triangle is: {0}", SideAltitude(side, alt));
        Console.WriteLine();
        Console.WriteLine("Enter three sides of a triangle - each on a separate line: ");
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());
        Console.WriteLine("The surface of this triangle is: {0}", ThreeSides(side1, side2, side3));
        Console.WriteLine();
        Console.WriteLine("Enter two sides of a triangle - each on a separate line: ");
        double side5 = double.Parse(Console.ReadLine());
        double side6 = double.Parse(Console.ReadLine());
        Console.Write("Enter the angle of a triangle: ");
        double angle = double.Parse(Console.ReadLine());
        Console.WriteLine("The surface of this triangle is: {0}", TwoSidesAngle(side5, side6, angle));
    }

    public static double SideAltitude(double side, double altitude)
    {
        return side * altitude / 2;
    }
    public static double ThreeSides(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        return Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
    }
    public static double TwoSidesAngle(double side1, double side2, double angle)
    {
        return side1 * side2 * Math.Sin((angle * Math.PI) / 180);
    }
 
}

