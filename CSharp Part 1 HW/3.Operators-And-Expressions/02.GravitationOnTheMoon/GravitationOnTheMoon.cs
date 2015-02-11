using System;

// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

namespace _02.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine("Enter the weight of a man on the Earth: ");
            double weightEarth = double.Parse(Console.ReadLine());
            double gravitationalField = (double)17 / 100;  // 17% 
            
            double weightMoon = weightEarth * gravitationalField;
            Console.WriteLine("The weigth of this man on the Moon will be {0}.", weightMoon);
        }
    }
}
