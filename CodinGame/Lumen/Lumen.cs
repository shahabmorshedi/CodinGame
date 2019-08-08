using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CodinGame.Lumen
{
    class Lumen
    {

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            string[,] square = new string[N, N];
            int v = 1;
            for (int i = 0; i < N; i++)
            {
                string LINE = Console.ReadLine();
                for (int j = 0; j < N; j++)
                {
                    square[i, j] = LINE.Split(' ')[j];
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    v = 1;
                    if (square[i, j] == "C")
                    {
                        while (v < L)
                        {
                            for (int m = i - v; m <= i + v; m++)
                            {
                                for (int n = j - v; n <= j + v; n++)
                                {
                                    if (m >= 0 && m < N && n >= 0 && n < N)
                                        if (square[m, n] == "X")
                                            square[m, n] = (L - v).ToString();
                                }
                            }
                            v++;
                            for (int a = 0; a < N; a++)
                            {
                                for (int b = 0; b < N; b++)
                                    Console.Write(square[a, b]);
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine((from string z in square
                               where z == "X"
                               select z).Count().ToString());
            Console.ReadLine();
        }
    }
}
