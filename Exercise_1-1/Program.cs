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
            DiceRoller Dice = new DiceRoller(Percentage);
            Dice.PrintResult(NumberRollers);
        }
    }
}
