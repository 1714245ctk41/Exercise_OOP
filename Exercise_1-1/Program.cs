using System;
using System.Collections.Generic;

namespace Exercise_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Percentage = { 0.3, 0.1, 0.1, 0.1, 0.1, 0.3 };
            int[] NumberRollers = { 100, 1000, 5000, 10000 };
            DiceRoller TestDice = new DiceRoller(Percentage);
            TestDice.PrintResult(NumberRollers, Percentage);
          
           
        }
    }
}
