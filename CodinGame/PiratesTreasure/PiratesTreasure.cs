using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.PiratesTreasure
{
    class PiratesTreasure
    {
        static void Main(string[] args)
        {
            int W = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int[,] z = new int[H, W];

            Console.Error.WriteLine(W * H);

            for (int i = 0; i < H; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < W; j++)
                {
                    z[i, j] = int.Parse(inputs[j]);
                }
            }

            for (int m = 0; m < H; m++)
            {
                for (int n = 0; n < W; n++)
                {
                    if (z[m, n] == 1)
                        continue;
                    bool x = true;
                    for (int i = m - 1; i <= m + 1 && x; i++)
                    {
                        if (i < 0 || i >= H) continue;
                        for (int j = n - 1; j <= n + 1 && x; j++)
                        {
                            if ((j < 0 || j >= W) || (m == i && n == j)) continue;
                            x = z[i, j] == 1;
                        }
                    }
                    if (x)
                    {
                        Console.WriteLine(n + " " + m);
                        break;
                    }
                }
            }


            Console.ReadLine();

            //Console.WriteLine((i % H) + " " + (i % W));


            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            //Console.WriteLine("0 0");
        }
    }
}
