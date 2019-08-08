using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//Find the sum of all the primes below two million.

namespace projectEuler._10_summationOfPrimes
{
    class summationOfPrimes
    {
        public static void Main(string[] args)
        {
            bool p = true;
            long s = 0;
            for (int i = 2; i < 2000000; i++)
            {
                p = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        p = false;
                        break;
                    }
                }
                if (p)
                {
                    if (i >= 2000000)
                        break;
                    Console.WriteLine(i);
                    s += i;
                }
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
