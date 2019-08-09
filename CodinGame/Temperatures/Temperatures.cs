using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.Temperatures
{
    class Temperatures
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n == 0 ? 0 : Console.ReadLine().Split(' ').Select(x => int.Parse(x)).Aggregate((i, j) => Math.Abs(i) == Math.Abs(j) ? (i > j ? i : j) : Math.Abs(i) < Math.Abs(j) ? i : j));
            Console.ReadLine();
        }
    }
}