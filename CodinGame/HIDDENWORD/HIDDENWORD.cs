using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.HIDDENWORD
{
    class HIDDENWORD
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                string aword = Console.ReadLine();
                words[i] = aword;
            }

            string[] inputs = Console.ReadLine().Split(' ');
            int h = int.Parse(inputs[0]);
            int w = int.Parse(inputs[1]);
            char[,] grid = new char[h, w];

            for (int i = 0; i < h; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < w; j++)
                    grid[i, j] = line[j];
            }

            for (int m = 0; m < words.Length; m++)
            {
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        if (grid[i, j] != '.' && grid[i, j] == words[m][0])
                        {
                            if (words[m].Length + j <= w)
                            {
                                string match = "";
                                for (int x = j; x < words[m].Length + j; j++)
                                    match += grid[i, x];
                                if (words[m] == match)
                                    for (int x = j; x < words[m].Length + j; j++)
                                        grid[i, x] = '.';
                            }
                            if (words[m].Length - j + 1 >= 0)
                            {
                                string match = "";
                                for (int x = j; x < words[m].Length - j + 1; j--)
                                    match += grid[i, x];
                                if (words[m] == match)
                                    for (int x = j; x < words[m].Length + j; j++)
                                        grid[i, x] = '.';
                            }
                            if (words[m].Length + i <= h)
                            {
                                string match = "";
                                for (int x = i; x < words[m].Length + h; j++)
                                    match += grid[x, j];
                                if (words[m] == match)
                                    for (int x = j; x < words[m].Length + j; j++)
                                        grid[x, j] = '.';
                            }
                            if (words[m].Length - i + 1 >= 0)
                            {
                                string match = "";
                                for (int x = i; x < words[m].Length - i + 1; j--)
                                    match += grid[x, j];
                                if (words[m] == match)
                                    for (int x = j; x < words[m].Length + j; j++)
                                        grid[x, j] = '.';
                            }
                            if ((words[m].Length + j <= w) && (words[m].Length + i <= h))
                            {
                            }
                            if ((words[m].Length - i + 1 >= 0) && (words[m].Length - j + 1 >= 0))
                            {
                            }
                            if ((words[m].Length + j <= w) && (words[m].Length - i + 1 >= 0))
                            {
                            }
                            if ((words[m].Length - j + 1 >= 0) && (words[m].Length - i + 1 >= 0))
                            {
                            }
                        }
                    }
                }
            }

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("word");
        }
    }
}