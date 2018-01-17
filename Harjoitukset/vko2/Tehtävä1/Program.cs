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
            Console.WriteLine("Anna numero > ");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Numero on yksi");
            }
            else if (number == 2)
            {
                Console.WriteLine("Numero on kaksi");
            }
            else if (number == 3)
            {
                Console.WriteLine("Numero on kolme");
            }
            else
            {
                Console.WriteLine("Joku muu luku");
            }
           
        }
    }
}
