using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

namespace projectEuler.largestPalindromeProduct
{
    class largestPalindromeProduct
    {

        public static void Main(string[] args)
        {
            long max = 0;
            long n = 0;
            long nz = 0;

            for (int i = 999; i > 899; i--)
            {
                for (int j = 999; j > 899; j--)
                {
                    long reverse = 0;
                    nz = n = i * j;
                    while (n != 0)
                    {
                        reverse *= 10;
                        reverse += n % 10;
                        n /= 10;
                    }
                    if (nz == reverse && max < reverse)
                    {
                        max = reverse;
                    }
                }
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
