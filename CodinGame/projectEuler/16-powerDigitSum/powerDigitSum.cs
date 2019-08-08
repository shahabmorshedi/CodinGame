using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
//What is the sum of the digits of the number 2^1000?


//NOTE: Note : Number of digits in x^y = Log(x^y) + 1

namespace projectEuler._16_powerDigitSum
{
    class powerDigitSum
    {
        public static void Main(string[] args)
        {
            double s = 0;
            double x = Math.Pow(2, 1000);
            while (x % 10 != 0)
            {
                s += x % 10;
                x /= 10;
            }


            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
