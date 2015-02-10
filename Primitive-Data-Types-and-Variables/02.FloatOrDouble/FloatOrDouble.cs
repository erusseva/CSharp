using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
// 34.567839023, 12.345, 8923.1234857, 3456.091

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            double first = 34.56783902;
            float second = 12.345f;
            double third = 8923.1234857;
            float fourth = 3456.091f;

            Console.WriteLine("double {0}\nfloat {1}\ndouble {2}\nfloat {3}", 
                first, second, third, fourth);
        }
    }
}
