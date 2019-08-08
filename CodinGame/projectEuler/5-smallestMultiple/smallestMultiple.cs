using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

namespace projectEuler.smallestMultiple
{
    class smallestMultiple
    {
        public static void Main(string[] args)
        {
            int n = 20;

            while (true)
            {
                bool b = false;
                for (int i = 1; i <= 20; i++)
                {
                    b = n % i > 0;
                    if (b)
                        break;
                }
                if (!b)
                {
                    Console.WriteLine(n);
                    break;
                }
                n++;
            }

            Console.ReadLine();
        }
    }
}
