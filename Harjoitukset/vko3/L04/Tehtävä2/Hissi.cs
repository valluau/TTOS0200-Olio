using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    static class Hissi
    {
        static private int floor;
        static public int Floor
        {
            get
            {                
                return floor;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Floor is too small!");
                }
                else if (value > 5)
                {
                    Console.WriteLine("Floor is too big!");
                }
                else
                {
                    floor = value;
                    Console.WriteLine("Elevator is now in floor: " + floor);
                }
            }
        }
        
    }
}
