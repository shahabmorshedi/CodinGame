using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,

//a^2 + b^2 = c^2
//For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.

namespace projectEuler.specialPythagoreanTriplet
{
    class specialPythagoreanTriplet
    {
        public static void Main(string[] args)
        {
            bool e = true;
            for (double c = 0; c < 1000 && e; c++)
            {
                for (double b = 0; b < 1000 && e; b++)
                {
                    for (double a = 0; a < 1000 && e; a++)
                    {
                        if (a + b + c == 1000)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = 1000");

                            if (Math.Sqrt(a) + Math.Sqrt(b) == Math.Sqrt(c))
                            {
                                Console.WriteLine($"{a}^2 + {b}^2 = {c}^2");
                                e = !e;
                            }
                        }

                    }
                }
            }

            Console.WriteLine("END.");
            Console.ReadLine();

        }
    }
}
