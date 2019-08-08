/*using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] H = new int[10000000];
        int D = -1;
        int prv = -1;

        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            H[pi] = pi;
        }

        for (int j = 0; j < H.Length; j++)
        {
            if (H[j] > 0)
            {
                if (prv > 0)
                {
                    int x = Math.Abs(H[j] - H[prv]);
                    if (D < 0)
                        D = x;
                    else
                        D = x < D ? x : D;
                }
                prv = H[j];
            }
        }


        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(D);
    }

}*/