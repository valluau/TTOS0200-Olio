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
            Console.WriteLine("Give a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = -1; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
    }
}
