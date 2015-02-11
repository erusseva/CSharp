using System;

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds). 

namespace _04.PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main()
        {
            string[] suit = { "spades", "clubs", "hearts", "diamonds" };
            string[] card = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 0; i < card.Length; i++)
            {
                for (int j = 0; j < suit.Length; j++)
                {
                    Console.Write("{0} of {1}", card[i], suit[j]);
                    if (j < suit.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
