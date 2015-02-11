using System;
using System.Threading;
using System.Globalization;

//Write a program that reads the radius r of a circle and prints its perimeter and area 
//formatted with 2 digits after the decimal point. 

namespace _3.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            //Change the decimal separator to "." (to avoid an exception for ",").
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter the radius of a circle: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine("Perimeter: {0:F2}\nArea: {1:F2}"
                , perimeter, area);
        }
    }
}
