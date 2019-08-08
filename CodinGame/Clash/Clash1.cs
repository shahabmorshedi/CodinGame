using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.Clash
{
    public class Clash1
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (i % 35 == 0)
                    Console.WriteLine("FooBar");
                else if (i % 5 == 0)
                    Console.WriteLine("Foo");
                else if (i % 7 == 0)
                    Console.WriteLine("Bar");
                else
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }


    }
}
