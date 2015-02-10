using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
// Do the above in two different ways - with and without using quoted strings.

namespace _07.QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string str1 = "The \"use\" of quotations causes difficulties.";
            string str2 = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
