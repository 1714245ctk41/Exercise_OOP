using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_1
{
    class DiceRoller
    {
    /*    public Dice[] Dice { get; set; }
        public double[] Percentage { get; set; } 
        public DiceRoller(double[] percentage)
        {
            Percentage = new double[percentage.Count()];
            Dice = new Dice[percentage.Count()];
            CreatePercentageForRoll(percentage);
            CreateDiceArray( percentage);
        }
        // initialize the Percentage Array
        public void CreatePercentageForRoll(double[] percentage)
        {
            double x = 0;
            for(int i=0; i<percentage.Count(); i++)
            {
                Percentage[i] = percentage[i] + x;
                x = Percentage[i];
            }
        }
        // initialize the Dice Array
        public void CreateDiceArray( double[] percentage)
        {
            for (int i = 0; i < Dice.Count(); i++)
            {
                Dice[i] = new Dice(i, percentage[i]);
            }
        }
        // Count the number of occurrences of the side
        public void CountNumberOfOccurrences(Double percentageRandom)
        {
            double x = 0;
            for(int i=0; i<Percentage.Count(); i++)
            {
                if (x < percentageRandom && percentageRandom <= Percentage[i])
                {
                    Dice[i].NumberOfOccurrences += 1;
                }
                x = Percentage[i];
            }
        }     
        // Print Result
        public void PrintResult(int[] NumberRollers, double[] percentage)
        {
            Random random = new Random();
            foreach (var numberRoller in NumberRollers)
            {
                Console.WriteLine($"Number of Roll: {numberRoller}");
                for (int i = 0; i < numberRoller; i++)
                {
                    double percentageRandom = random.NextDouble();
                    CountNumberOfOccurrences(percentageRandom);
                }
                foreach (var item in Dice)
                {
                    Console.WriteLine($"The number and the percentage of occurrences of {item.NumberSide}: "
                        + $"{item.NumberOfOccurrences}".PadRight(10) + $"{item.NumberOfOccurrences * 100 / numberRoller}".PadRight(7) + " %");
                }
                CreateDiceArray( percentage);
            }
        }*/
    }
}
