using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.GhostLegs
{
    class GhostLegs
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int W = int.Parse(inputs[0]);
            int H = int.Parse(inputs[1]);
            char[,] m = new char[H, W];
            for (int i = 0; i < H; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < line.Length; j++)
                    m[i, j] = line[j];
            }

            int n = 0;
            for (int i = 0; i < W; i++)
            {
                if (m[0, i] != ' ')
                {
                    int h = 1;
                    int w = i;
                    string s = string.Format("{0}{1}", m[0, i], n);
                    while (h < H)
                    {
                        if (w <= 0)
                        {
                            if (m[h, w + 1] == '-')
                                w += 3;
                        }
                        else if (w >= W - 1)
                        {
                            if (m[h, w - 1] == '-')
                                w -= 3;
                        }
                        else
                        {
                            if (m[h, w + 1] == '-')
                                w += 3;
                            else if (m[h, w - 1] == '-')
                                w -= 3;
                        }
                        if (h == H - 1)
                        {
                            s = s[0].ToString() + m[h, w].ToString();
                            Console.WriteLine(s);
                            break;
                        }
                        h++;
                    }
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.ReadLine();
        }
    }
}
