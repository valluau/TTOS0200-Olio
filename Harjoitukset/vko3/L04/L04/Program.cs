using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            tank.Name = "tankki";
            tank.Type = "tyyppi";
            tank.CrewCount = 8;            

            tank.PrintData();
            Console.ReadLine();

            tank.AccelerateTo(50);
            tank.PrintData();
            Console.ReadLine();

            tank.SlowTo(10);
            tank.PrintData();
            Console.ReadLine();

            tank.AccelerateTo(50);
            tank.PrintData();
            Console.ReadLine();

            tank.SlowTo(70);
            tank.PrintData();
            Console.ReadLine();

            tank.PrintData();
            Console.ReadLine();


        }
    }
}
