using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.foobar.prime
{
    class Answer1
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();
            int n = int.Parse(Console.ReadLine());
            string p = "";
            bool isp = true;
            String r = "";
            // Your code goes here.1.8 1.2
            for (int i = 2; n > p.Length - 5; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isp = false;
                        break;
                    }
                }
                if (isp)
                    p += i.ToString();
                isp = true;
            }
            r = p.Substring(n, 5);
            sw.Stop();
            Console.WriteLine("prime string:'" + p + "'");
            Console.WriteLine("string length:'" + p.Length + "'");
            Console.WriteLine("asnwer:'" + r + "'");
            Console.WriteLine("execute time:'" + sw.Elapsed + "'");
            Console.ReadLine();
        }
    }
}
