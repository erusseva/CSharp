using System;
using System.Threading;
using System.Globalization;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    //If the variable is int or double, the program increases it by one.
    //If the variable is a string, the program appends * at the end.


namespace _09.PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please choose a variable type:\n1 --> int\n2 --> double\n3 --> string");
            byte userChoice = byte.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Console.Write("Enter an integer: ");
                    int intNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", ++intNumber);
                    break;
                case 2:
                    Console.Write("Enter a double: ");
                    double floatingN = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", ++floatingN);
                    break;
                case 3:
                    Console.WriteLine("Enter a string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine("Result: {0}*", str);
                    break;
                default: Console.WriteLine("The input must be 1, 2 or 3");
                    break;
            }
        }
    }
}
