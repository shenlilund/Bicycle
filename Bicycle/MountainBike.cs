using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle
{
    class MountainBike : Bicycle
    {
        private int numGears;

        public MountainBike(int gears, Wheel w1, Wheel w2, string c) : base(w1, w1, c)
        {
            numGears = gears;
        }

        public void displayBike()
        {
            Console.WriteLine("This is a mountain bicycle");
            Console.WriteLine("This bike has " + numGears + " gears");
            base.displayBike();
        }
    }
}
