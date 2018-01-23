using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä3
{
    class Vahvistin
    {
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < 0)
                {
                    volume = 0;
                    Console.WriteLine("Too low volume - amplifier is set to minimum: " + volume);
                }
                else if (value > 100)
                {
                    volume = 100;
                    Console.WriteLine("Too much volume - amplifier is set to maximum: " + volume);
                }
                else
                {
                    volume = value;
                    Console.WriteLine("Amplifier volume is set to: " + volume);
                }
            }
        }
    }
}
