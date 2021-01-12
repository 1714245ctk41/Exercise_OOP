using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_1
{
    class Dice
    {
        public int NumFaces{ get; set; }
        public int[] FaceProbability{ get; set; }
        public Dice(int numFaces, int[] faceProbability)
        {
            FaceProbability = faceProbability;
            NumFaces = numFaces;
        }
    }
}
