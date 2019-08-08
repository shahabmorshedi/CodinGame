using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.foobar.bunny_prisoner_locating
{
    class bunny_prisoner_locating
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            // Your code goes here.
            long id = 0;
            for (int i = 1; i <= x; i++)
            {
                id += i;
            }

            for (int i = 0; i < y - 1; i++)
            {
                id += x + i;
            }

            Console.WriteLine(id);

            Console.ReadLine();

        }
    }
}
