using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first floating-point number: ");
            double a = Double.Parse(Console.ReadLine());

            Console.Write("Enter the second floating-point number: ");
            double b = Double.Parse(Console.ReadLine());
            float eps = 0.000001f;
            bool equal = Math.Abs(a - b) < eps;

            Console.WriteLine("These two floating-point numbers are equal: {0}", equal);
        }
    }
}
