using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Tank
    {
        public string Name { get; set; }
        public string Type { get; set; }
        private int crewCount;
        public int CrewCount
        {
            get
            {
                return crewCount;
            }
            set
            {
                if (value > 6)
                {
                    crewCount = 2;
                    Console.WriteLine("Crew count invalid - set to 2");
                }
                else if (value < 2)
                {
                    crewCount = 2;
                    Console.WriteLine("Crew count invalid - set to 2");
                }
                else
                {
                    crewCount = value;
                }
            }
        }
        private float speed;
        public float Speed
        {
            get
            {                               
                return speed;
            }
        }
        private static float SpeedMax = 100;        
        public float AccelerateTo(float accInput)
        {
            if (accInput > SpeedMax)
            {
                Console.WriteLine("Too much speed - set to maximum!");
                speed = SpeedMax;
                return speed;
            }            
            else
            {
                speed += accInput;
                return speed;
            }
        }
        public float SlowTo(float decInput)
        {
            speed -= decInput;
            if (speed > SpeedMax)
            {
                Console.WriteLine("Too much speed - set to maximum!");
                return SpeedMax;
            }
            else if (speed < 0)
            {
                Console.WriteLine("Speed went below 0 - set to 0!");
                speed = 0;
                return speed;
            }
            else
            {
                return speed;
            }
        }

        public void PrintData()
        {
            Console.WriteLine("Tank data: ");
            Console.WriteLine("-name: " + Name);
            Console.WriteLine("-type: " + Type);
            Console.WriteLine("-crew count: " + CrewCount);
            Console.WriteLine("-speed: " + Speed);
        }
    }
}
