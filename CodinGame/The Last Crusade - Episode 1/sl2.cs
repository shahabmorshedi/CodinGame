using System;
using System.Linq;
using System.Collections.Generic;

class sl2
{
    static void Main()
    {
        var inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]);
        int H = int.Parse(inputs[1]);
        int[,] TabMap = new int[H, W];

        for (int i = 0; i < H; i++)
        {
            var Line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int a = 0; a < W; a++)
            {
                TabMap[i, a] = Line[a];
            }
        }

        Console.ReadLine();

        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int Xi = int.Parse(inputs[0]);
            int Yi = int.Parse(inputs[1]);
            String Pos = inputs[2];

            switch (TabMap[Yi, Xi])
            {
                case 0: break;
                case 1: Yi++; break;
                case 2: Xi += Pos.Contains("LEFT") ? 1 : -1; break;
                case 3: Yi++; break;
                case 4: if (Pos.Contains("RIGHT")) Yi++; else Xi--; break;
                case 5: if (Pos.Contains("LEFT")) Yi++; else Xi++; break;
                case 6: Xi += Pos.Contains("LEFT") ? 1 : -1; break;
                case 7: Yi++; break;
                case 8: Yi++; break;
                case 9: Yi++; break;
                case 10: Xi--; break;
                case 11: Xi++; break;
                case 12: Yi++; break;
                case 13: Yi++; break;
            }

            Console.WriteLine(Xi + " " + Yi);
        }
    }
}