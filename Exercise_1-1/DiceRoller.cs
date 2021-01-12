using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_1
{
    public class DiceRoller
    {
        public Dice Dice { get; set; }
        public DiceRoller(int[] percentage)
        {

            Dice = new Dice(percentage.Count(), percentage);

        }
        // Print Result
        public void PrintResult(int[] NumberRollers)
        {
            foreach (var numberRoller in NumberRollers)
            {
                Console.WriteLine($"Number of Roll: {numberRoller}");
                int[] numberOccur = new int[Dice.NumFaces];
                for (int i = 0; i < numberRoller; i++)
                {
                    numberOccur[Dice.Roll()] += 1;
                }
                for (int i = 0; i < numberOccur.Length; i++)
                {
                    Console.WriteLine($"The number and the percentage of occurrences of {i + 1}: "
                        + $"{numberOccur[i]}".PadRight(10) + $"{numberOccur[i] * 100 / numberRoller}".PadRight(7) + " %");
                }
                
            }
        }
    }
}
