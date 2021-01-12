using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_1
{
    public class Dice
    {
        private readonly Random _random = new Random();
        public int NumFaces{ get; set; }
        public int[] FaceProbability{ get; set; }
        public Dice(int numFaces, int[] faceProbability)
        {
            NumFaces = numFaces;

            FaceProbability = faceProbability;
        }
        public int Roll()
        {
            var value = _random.Next(1, 101);
            var sum = 0.0;
            for(var i=0; i<FaceProbability.Length; i++)
            {
                sum += FaceProbability[i];
                if (sum >= value)
                {
                    return i;
                }
            }
            throw new InvalidOperationException();

        }
    }
}
