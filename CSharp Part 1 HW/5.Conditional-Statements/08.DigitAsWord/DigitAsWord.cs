﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
    //Print “not a digit” in case of invalid input.
    //Use a switch statement.

namespace _08.DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            Console.Write("Please enter a digit [0:9] : ");
            string inputN = Console.ReadLine();
            int number = 0;
            bool isDigit = Int32.TryParse(inputN, out number);
            if (isDigit)
            {
                string name = " ";
                switch (number)
                {
                    case 0: Console.WriteLine("Zero");
                        break;
                    case 1: Console.WriteLine("One");
                        break;
                    case 2: Console.WriteLine("Two");
                        break;
                    case 3: Console.WriteLine("Three");
                        break;
                    case 4: Console.WriteLine("Four");
                        break;
                    case 5: Console.WriteLine("Five");
                        break;
                    case 6: Console.WriteLine("Six");
                        break;
                    case 7: Console.WriteLine("Seven");
                        break;
                    case 8: Console.WriteLine("Eight");
                        break;
                    case 9: Console.WriteLine("Nine");
                        break;                   
                    default: Console.WriteLine("Not a digit!");
                        break;
                }
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Not a digit");
            } 
        }
    }
}
