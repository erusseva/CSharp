using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a program that assigns null values to an integer and to a double variable.

namespace _12.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? a = 0;
            double? b = 0;
            Console.WriteLine("1. Assigning null values: a = {0}, b = {1}", a, b);
            a = null;
            b = null;
            Console.WriteLine("2. Adding null literal: a = {0}, b = {1}", a, b);
            a = 10;
            b = 20;
            Console.WriteLine("3. Adding values 10 and 20: a = {0}, b = {1}", a, b);
        }
    }
}
