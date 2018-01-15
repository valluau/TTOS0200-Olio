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
            Console.WriteLine("Give point limit : ");
            int limit = int.Parse(Console.ReadLine());
            if (limit == 0 || limit == 1)
            {
                Console.WriteLine("School number is 0");
            }
            if (limit == 2 || limit == 3)
            {
                Console.WriteLine("School number is 1");
            }
            if (limit == 4 || limit == 5)
            {
                Console.WriteLine("School number is 2");
            }
            if (limit == 6 || limit == 7)
            {
                Console.WriteLine("School number is 3");
            }
            if (limit == 8 || limit == 9)
            {
                Console.WriteLine("School number is 4");
            }
            if (limit >= 10 && limit <= 12)
            {
                Console.WriteLine("School number is 5");
            }
        }
    }
}
