using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class TheDigitalRiverI
{
    static void Main(string[] args)
    {
        long r1 = long.Parse(Console.ReadLine());
        long r2 = long.Parse(Console.ReadLine());
        List<long> s1 = new List<long>() { r1 };
        long r = 0;

        while (true)
        {
            for (int i = 0; i < 100; i++)
            {
                r1 += r1.ToString().ToArray().Sum(c => int.Parse(c.ToString()));
                s1.Add(r1);
            }

            if (s1.Contains(r2))
            {
                r = r2;
                break;
            }

            while (r2 <= r1)
            {
                r2 += r2.ToString().ToArray().Sum(c => int.Parse(c.ToString()));
                if (s1.Contains(r2))
                {
                    r = r2;
                    break;
                }
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        Console.WriteLine(r);
    }
}