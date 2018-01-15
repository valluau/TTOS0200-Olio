using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä6
{
    class Program
    {
        static void Main(string[] args)
        {
            double kulutus1 = 7.02;
            double bensa = 1.595;

            Console.WriteLine("Give distance: ");
            int matka = int.Parse(Console.ReadLine());

            double kulutus2 = (kulutus1 / 100) * matka;
            double hinta = kulutus2 * bensa;

           
            Console.WriteLine("Gasoline consume is {0} liters and cost is {1} euros", kulutus2, hinta);
        }
    }
}
