using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_1
{
    class Dice
    {
        public int NumberSide { get; set; }
        public double NumberOfOccurrences { get; set; }
        public Dice(int numberSide, double percentage)
        {
            Percentage = percentage;
            NumberSide = numberSide;
            NumberOfOccurrences = 0.0;
        }
    }
}
