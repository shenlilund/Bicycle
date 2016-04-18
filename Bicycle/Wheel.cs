using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle
{
    class Wheel
    {
        private int diameter;
        private string tireType;

        public Wheel(int d, string t)
        {
            diameter = d;
            tireType = t;
        }

        public void displayWheel()
        {
            Console.Write("This wheel has a diameter of " + diameter + " and the tire type is: " + tireType);
        }
    }
}
