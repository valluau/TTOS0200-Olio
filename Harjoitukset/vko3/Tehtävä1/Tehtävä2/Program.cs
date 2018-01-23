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
            int[] numbers;
            numbers = new int[5];
            Console.WriteLine("Give a number: ");
            numbers[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Give a number: ");
            numbers[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Give a number: ");
            numbers[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Give a number: ");
            numbers[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Give a number: ");
            numbers[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers are {0}, {1}, {2}, {3}, {4}", numbers[4], numbers[3], numbers[2], numbers[1], numbers[0]);
        }
    }
}
