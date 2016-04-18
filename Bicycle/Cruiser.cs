using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle
{
    class Cruiser : Bicycle
    {
        private bool basket;

        public Cruiser(bool b, Wheel w1, Wheel w2, string c) : base(w1, w1, c)
        {
            this.basket = b;
        }

        public override void displayBike()
        {
            Console.WriteLine("This is a cruiser bicycle");
            if (basket == true)
            {
                Console.WriteLine("This bike has a basket");
            }
            else
            {
                Console.WriteLine("This bike doesn't have a basket");
            }
            base.displayBike();
            
        }
    }
}
