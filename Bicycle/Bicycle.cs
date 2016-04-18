using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle
{
    class Bicycle
    {
        private Wheel wheel1;
        private Wheel wheel2;
        private string color;

        public Bicycle(Wheel w1, Wheel w2, string c)
        {
            wheel1 = w1;
            wheel2 = w2;
            color = c;
        }

        public virtual void displayBike()
        {
            Console.WriteLine("This bike is " + color);
            Console.WriteLine("It has the following wheels: ");
            Console.Write("Wheel 1: ");
            wheel1.displayWheel();
            Console.Write("\nWheel 2: ");
            wheel2.displayWheel();
        }   

        static void Main(string[] args)
        {
            Bicycle bike = null;

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
                    Console.WriteLine("Please type 1, 2, or 3 \r\n");
                }

                Console.WriteLine("What type of Bicycle do you want? \r\n 1. Mountain Bike \r\n 2. Cruiser");
                bikeType = Console.ReadLine();
            }

            //get the color of the bike
            Console.WriteLine("Enter the color of the bike: ");
            string color = Console.ReadLine();

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
                    Console.WriteLine("Error, please type a number: ");
                }

                Console.WriteLine("Enter the wheel diameter: ");
                wheelSize = Console.ReadLine();
            }

            //get the tire type
     
            Console.WriteLine("Enter the tire type: ");
            string tire = Console.ReadLine();

            Wheel w1 = new Wheel(wheelSizeInt, tire);
            Wheel w2 = new Wheel(wheelSizeInt, tire);

            if (bikeTypeInt == 1)
            {
                //get the number of gears for mountain bike
                string gears = "";
                int gearsInt = 0;
                int flag = 1;
                while (!(Int32.TryParse(gears, out gearsInt)))
                {
                    if (flag == 1)
                    {
                        flag = 0;
                    }
                    else
                    {                    
                        Console.WriteLine("Please type a number");
                    }

                    Console.WriteLine("How many gears does this mountain bike have?");
                    gears = Console.ReadLine();
                }

                bike = new MountainBike(gearsInt, w1, w2, color);
            }
            else if (bikeTypeInt == 2)
            {
                //see if the cruiser bike has a basket or not
                string basket = "";
                int flag = 1;
                while (!(basket == "yes" || basket == "no"))
                {
                    if (flag == 1)
                    {
                        flag = 0;
                    }
                    else
                    {
                        Console.WriteLine("Please type yes or no");
                    }

                    Console.WriteLine("Does this bike have a basket?");
                    basket = Console.ReadLine();
                }
                bool b;
                if (basket == "yes")
                {
                    b = true;
                }
                else
                {
                    b = false;
                }
                bike = new Cruiser(b, w1, w2, color);
            }

            bike.displayBike();

            //User hits enter to close the program.
            Console.ReadLine();
        }
    }
}
