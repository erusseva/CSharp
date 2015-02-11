using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Declare two string variables and assign them with Hello and World.
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            object var = str1 + " " + str2;
            string str3 = (string)var;
            Console.WriteLine("Object variable = " + var);
            Console.WriteLine("String 3 = " + str3);
        }
    }
}
