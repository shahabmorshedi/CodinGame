using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler.selfPowers
{
    class selfPowers
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 1; i <= 1000; i++)
                sum += Math.Pow(i, i);

            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
