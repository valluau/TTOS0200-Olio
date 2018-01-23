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
            int value = 0;
            Vahvistin amp = new Vahvistin();
            while (true)
            {
                Console.WriteLine("Give a new volume value (0-100) > ");
                value = int.Parse(Console.ReadLine());
                amp.Volume = value;
            }
        }
    }
}
