using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foobar.the_grandest_staircase_of_them_all
{
    class the_grandest_staircase_of_them_all
    {
        public static void Main(string[] args)
        {
            Console.Write(Answer(int.Parse(Console.ReadLine())));
            Console.ReadLine();
        }

        public static int Answer(int n)
        {
            return partition(n);
        }


        public static int partition(int n)
        {
            int c = 0;
            int x = 0;
            int[] a = new int[n];

            for (int m = 0; m < n; m++)
            {
                x += m;

                for (int i = m + 1; i <= n / 2; i++)
                {
                    for (int j = n - i - x; j >= (n / 2) + 1; j--)
                    {
                        if (x + i + j == n)
                        {

                            c++;
                        }
                    }

                }
            }

            return c;
        }

    }
}