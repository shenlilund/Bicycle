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
        string color;

        public Bicycle(Wheel w1, Wheel w2, string c)
        {
            wheel1 = w1;
            wheel2 = w2;
            color = c;
        }

        static void Main(string[] args)
        {
            //get the type of bicycle from user input
            string bikeType = "";
            int bikeTypeInt = 0;
            int firstFlag = 1;
            while (!(Int32.TryParse(bikeType, out bikeTypeInt)))
            {
                if (firstFlag == 1)
                {
                    firstFlag = 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please type 1, 2, or 3 \r\n");
                }

                Console.WriteLine("What type of Bicycle do you want? \r\n 1. Mountain Bike \r\n 2. Cruiser \r\n 3. BMX");
                bikeType = Console.ReadLine();
            }

            //get the wheel diameter from user input
            String wheelSize = "";
            int wheelSizeInt = 0;
            firstFlag = 1;
            while (!(Int32.TryParse(wheelSize, out wheelSizeInt)))
            {
                if (firstFlag == 1)
                {
                    firstFlag = 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error, please type a number: ");
                }

                Console.WriteLine("Enter the wheel diameter: ");
                wheelSize = Console.ReadLine();
            }

            //get the tire type
            Console.Clear();
            Console.WriteLine("Enter the tire type: ");
            string tire = Console.ReadLine();

            Wheel w1 = new Wheel(wheelSizeInt, tire);
            Wheel w2 = new Wheel(wheelSizeInt, tire);

            if (bikeTypeInt == 1)
            {

            }
            else if (bikeTypeInt == 2)
            {
                
            }
            else if (bikeTypeInt == 3)
            {

            }

            //User hits enter to close the program.
            Console.ReadLine();
        }
    }
}
