using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

namespace _14.PrintTheASCIITable
{
    class ASCIITable
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
           
            for (int symbol = 0; symbol < 256; symbol++)
            {
                Console.WriteLine((char)symbol);
            }    
        }
    }
}
