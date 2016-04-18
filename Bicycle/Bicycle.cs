using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle
{
    class Bicycle
    {
        Wheel wheel1;
        Wheel wheel2;

        static void Main(string[] args)
        {
            string input = "";
            int num = 0;
            int firstFlag = 1;
            while (!(Int32.TryParse(input, out num)))
            {
                if (firstFlag == 1)
                {
                    firstFlag = 0;
                }
                else
                {
                    Console.WriteLine("Please 1, 2, or 3");
                }

                Console.WriteLine("What type of Bicycle do you want? \r\n 1. Mountain Bike \r\n 2. Cruiser \r\n 3. BMX");
                input = Console.ReadLine();
            }


            //User hits enter to close the program.
            Console.ReadLine();
        }
    }
}
