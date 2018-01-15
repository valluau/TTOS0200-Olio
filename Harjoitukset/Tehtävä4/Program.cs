using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ikä: ");
            int ika = int.Parse(Console.ReadLine());
            if (ika < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
            else if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }
        }
    }
}
