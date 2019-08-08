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
class BlowingFuse
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int n = int.Parse(inputs[0]);
        int m = int.Parse(inputs[1]);
        int c = int.Parse(inputs[2]);
        inputs = Console.ReadLine().Split(' ');

        int totalUse = 0;
        Dictionary<int, List<int>> devices = new Dictionary<int, List<int>>();

        Console.Error.WriteLine($"{c}");

        for (int i = 0; i < n; i++)
        {
            int nx = int.Parse(inputs[i]);
            List<int> z = new List<int>();
            z.Add(nx);
            z.Add(0);
            devices.Add(i, z);
        }
        inputs = Console.ReadLine().Split(' ');

        for (int i = 0; i < m; i++)
        {
            int mx = int.Parse(inputs[i]) - 1;
            if (devices[mx][1] == 0)
            {
                devices[mx][1]++;
                totalUse += devices[mx][0];
                if (totalUse > c)
                {
                    Console.WriteLine("Fuse was blown.");
                    break;
                }
                Console.Error.WriteLine($"{totalUse} + {devices[mx][0]} = {totalUse}");
            }
            else
            {
                devices[mx][1]--;
                Console.Error.WriteLine($"{totalUse} + {0} = {totalUse}");
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        Console.Error.WriteLine($"{totalUse}");

        if (totalUse < c)
        {
            Console.WriteLine("Fuse was not blown.");
            Console.WriteLine($"Maximal consumed current was {totalUse} A.");
        }
    }
}