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
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<int> Z = new List<int>();
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            Z.Add(pi);
        }
        Z.Sort();
        int D = Math.Abs(Z[0] - Z[1]);
        for (int i = 1; i < Z.Count - 1; i++)
            if (Math.Abs(Z[i] - Z[i + 1]) < D)
                D = Math.Abs(Z[i] - Z[i + 1]);
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(D);
    }
}