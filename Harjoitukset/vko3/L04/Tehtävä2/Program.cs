using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 1;
            Console.WriteLine("Give a new floor number (1-5) > ");
            while (true)
            {
                value = int.Parse(Console.ReadLine());
                Hissi.Floor = value;
            }
        }
    }
}
