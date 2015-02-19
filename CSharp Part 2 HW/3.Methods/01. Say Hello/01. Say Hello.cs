using System;

class SayHello
{
    //Write a method that asks the user for his name and prints “Hello, <name>”
    //Write a program to test this method.

    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main()
    {
        Console.Write("Enter your name: ");
        string inputName = Console.ReadLine();
        PrintName(inputName);
    }
}
