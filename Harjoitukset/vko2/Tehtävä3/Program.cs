using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kolme lukua");
            Console.WriteLine("Ensimmäinen luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Toinen luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolmas luku: ");
            int luku3 = int.Parse(Console.ReadLine());

            int summa = luku1 + luku2 + luku3;

            int ka = summa / 3;

            Console.WriteLine("Lukujen summa: " + summa + " Lukujen keskiarvo: " + ka);
            
        }
    }
}
