using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler._7_10001stPrime
{
    class _10001stPrime
    {
        public static void Main(string[] args)
        {
            int k = 1;
            bool isprime = true;

            for (int i = 2; true; i++)
            {
                isprime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.WriteLine($"{k}:{i}");
                    if (k == 10001)
                        break;
                    k++;
                }
            }

            Console.ReadLine();
        }
    }
}
