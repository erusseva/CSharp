using System;

/*•	Write a program that reads an integer number and calculates and prints its square root.
    o	If the number is invalid or negative, print Invalid number.
    o	In all cases finally print Good bye.*/

class SquareRoot
{
    static void Main()
    {
        int sqrt = 0;
        Console.Write("Enter an integer: ");
        try
        {
            sqrt = int.Parse(Console.ReadLine());
            if (sqrt < 0)
            {
                throw new Exception("Invalid number - negative number!");
            }
            else
            {
                Console.WriteLine(Math.Sqrt(sqrt));
            }
        }
        catch (FormatException FE)
        {
            throw new FormatException("Invalid number - " + FE.Message);
        }
        catch (OverflowException OE)
        {
            throw new OverflowException("Too big number - " + OE.Message);
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }

    }
}

