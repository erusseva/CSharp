using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
// Print the variable values before and after the exchange.

namespace _09.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Values before exchange: a={0} and b={1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Values after exchange: a={0} and b={1}", a, b);
        }
    }
}
