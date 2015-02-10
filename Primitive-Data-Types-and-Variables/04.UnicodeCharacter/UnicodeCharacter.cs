using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.

namespace _04.UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            char star = '\u002A';
            Console.WriteLine(star);
        }
    }
}
