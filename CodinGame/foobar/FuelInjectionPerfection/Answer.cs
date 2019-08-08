using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace foobar.FuelInjectionPerfection
{
    class FuelInjectionPerfection
    {
        static int o = 0;
        static void Main(string[] args)
        {
            var x = long.Parse(Console.ReadLine());
            int v = 0;

            while (true)
            {
                v++;
                var q = Answer4(v, 1);
                var u = Answer4(v, -1);
                Console.WriteLine($"{v}:{q} & {v - 1}:{u} --> {Math.Min(q, u)}");
                Thread.Sleep(1000);
            }


            Console.ReadLine();
        }

        static int Answer(string x)
        {
            int num = int.Parse(x);
            int numberOfOperations = 0;

            if (num % 2 != 0)
            {
                num++;
                numberOfOperations++;
            }

            while (true)
            {
                if (num == 1)
                    return numberOfOperations;

                num >>= 1;//num /= 2;

                numberOfOperations++;
            }

        }

        static int Answer2(long x)
        {
            if (x == 1)
                return o;
            else if ((x & 1) != 0)
            {
                o++;
                x++;
            }

            x >>= 1;
            o++;
            return Answer2(x);
        }

        static int Answer3(long x)
        {
            int steps = 0;
            while (x > 1)
            {
                if ((x & 1) == 0)
                    x >>= 1;
                else if ((x == 3) || ((x + 1) & x) > ((x - 1) & (x - 2)))
                    x -= 1;
                else
                    x += 1;
                steps++;
            }
            return steps;
        }

        public static int Answer4(int x, int d)
        {
            int steps = 0;
            while (x > 1)
            {
                if (x % 2 == 0)
                {
                    x /= 2;
                    steps++;
                }
                else
                {
                    x += d;
                    steps++;
                }
            }
            return steps;
        }

    }
}

//public static int answer(String x)
//{
//    BigInteger n = new BigInteger(x);
//    int steps = 0;

//    while (!n.equals(BigInteger.valueOf(1)))
//    {
//        if ((n.mod(BigInteger.valueOf(2))).intValue() == 0)
//            n = n.divide(BigInteger.valueOf(2));
//        else
//        {
//            if (n.equals(BigInteger.valueOf(3)) || n.mod(BigInteger.valueOf(4)).intValue() == 1)
//                n = n.subtract(BigInteger.valueOf(1));
//            else
//                n = n.add(BigInteger.valueOf(1));
//        }
//        steps++;
//    }
//    return steps;
//}