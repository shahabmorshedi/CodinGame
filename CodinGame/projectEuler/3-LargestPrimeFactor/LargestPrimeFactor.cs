using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?
namespace projectEuler.LargestPrimeFactor
{
    class LargestPrimeFactor
    {
        public static void Main(string[] args)
        {
            Console.Write("Find the prime factors of a number.");
            Console.Write("Enter a number:");
            long n = long.Parse(Console.ReadLine());
            var watch = System.Diagnostics.Stopwatch.StartNew();

            //Console.WriteLine(solution1(n));
            Console.WriteLine(solution2(n));

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static long solution1(long n)
        {
            long max = 0;
            bool isp = false;
            for (long i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isp = false;
                    for (long j = 2; j <= i / 2 && !isp; j++)
                        if (i % j == 0)
                            isp = true;
                    if (!isp && max < i)
                        max = i;
                }
            }
            return max;
        }

        private static long solution2(long n)
        {
            long max = 0;
            //bool isp = false;
            //for (long i = 2; i <= n / 2; i++)
            //{
            //    for (long j = 2; j < i / 2; j++)
            //        if (i % j == 0)
            //        {
            //            isp = true;
            //            break;
            //        }
            //    if (!isp && n % i == 0 && max < i)
            //        max = i;
            //}
            return max;
        }
    }
}
