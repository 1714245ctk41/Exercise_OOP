using System;
using System.Collections.Generic;

namespace Exercise_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Percentage = { 30, 10, 10, 10, 10, 30 };
            int[] NumberRollers = { 100, 1000, 5000, 10000 };
            Dice Dice = new Dice(Percentage.Length,Percentage);
            
            foreach(var numberRoller in NumberRollers)
            {
                Console.WriteLine($"Number of Roll: {numberRoller}");
                for (int i = 0; i < Percentage.Length; i++)
                {
                    Console.WriteLine($"The number and the percentage of occurrences of {i + 1}: "
                      + $"{Dice.FaceProbability[i] * numberRoller / 100}".PadRight(10) + $"{Dice.FaceProbability[i]}".PadRight(7) + " %");
                }
                Console.WriteLine();
            }
        }
    }
}
