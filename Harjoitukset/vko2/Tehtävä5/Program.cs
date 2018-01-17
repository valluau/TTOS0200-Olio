using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä5
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = 0, minutes = 0, hours = 0;
            Console.WriteLine("Give seconds: ");
            seconds = int.Parse(Console.ReadLine());

            if (seconds > 59)
            {
                minutes = seconds / 60;
                seconds = minutes % 60;

                if (minutes > 59)
                {
                    hours = minutes / 60;
                    minutes = hours % 60;
                }
            }

            Console.WriteLine("Seconds can be shown as {0} hour(s) {1} minute(s) and {2} second(s)", hours, minutes, seconds);

        }
    }
}
