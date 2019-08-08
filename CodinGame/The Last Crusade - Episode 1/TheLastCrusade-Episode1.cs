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
namespace CodinGame.The_Last_Crusade___Episode_1
{
    class TheLastCrusade_Episode1
    {
        static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int W = int.Parse(inputs[0]); // number of columns.
            int H = int.Parse(inputs[1]); // number of rows.
            int[,] grid = new int[W, H];
            Hashtable route = new Hashtable();

            Console.Error.WriteLine("W:{0} H:{1}", W, H);

            for (int i = 0; i < H; i++)
            {
                string LINE = Console.ReadLine(); // represents a line in the grid and contains W integers. Each integer represents one room of a given type.
                string[] row = LINE.Split(' ');
                for (int j = 0; j < W; j++)
                {
                    grid[j, i] = int.Parse(row[j]);
                    Console.Error.Write(" {0} ", grid[j, i]);
                }
                Console.Error.WriteLine();
            }
            int EX = int.Parse(Console.ReadLine()); // the coordinate along the X axis of the exit (not useful for this first mission, but must be read).

            // game loop
            while (true)
            {
                inputs = Console.ReadLine().Split(' ');
                int XI = int.Parse(inputs[0]);
                int YI = int.Parse(inputs[1]);
                string POS = inputs[2];

                Console.Error.WriteLine("x:{0} y:{1} t:{2} p:{3}", XI, YI, grid[XI, YI], POS);

                if (grid[XI, YI] == 1)
                {
                    Console.WriteLine(string.Format("{0} {1}", XI, ++YI));
                    continue;
                }
                else if (grid[XI, YI] == 2)
                {
                    if (POS == "LEFT")
                        Console.WriteLine(string.Format("{0} {1}", ++XI, YI));
                    else if (POS == "RIGHT")
                        Console.WriteLine(string.Format("{0} {1}", --XI, YI));
                    continue;
                }
                else if (grid[XI, YI] == 3)
                {
                    Console.WriteLine(string.Format("{0} {1}", XI, ++YI));
                    continue;
                }
                else if (grid[XI, YI] == 4)
                {
                    if (POS == "TOP")
                        Console.WriteLine(string.Format("{0} {1}", --XI, YI));
                    else if (POS == "RIGHT")
                        Console.WriteLine(string.Format("{0} {1}", XI, ++YI));
                    continue;
                }
                else if (grid[XI, YI] == 5)
                {
                    if (POS == "TOP")
                        Console.WriteLine(string.Format("{0} {1}", ++XI, YI));
                    else if (POS == "LEFT")
                        Console.WriteLine(string.Format("{0} {1}", XI, ++YI));
                    continue;
                }
                else if (grid[XI, YI] == 6)
                {
                    if (POS == "LEFT")
                        Console.WriteLine(string.Format("{0} {1}", ++XI, YI));
                    else if (POS == "RIGHT")
                        Console.WriteLine(string.Format("{0} {1}", --XI, YI));
                    continue;
                }
                else if (grid[XI, YI] == 7)
                {
                    Console.WriteLine(string.Format("{0} {1}", XI, ++YI));
                    continue;
                }
                else if (grid[XI, YI] == 8)
                {
                    Console.WriteLine(string.Format("{0} {1}", XI, ++YI));
                    continue;
                }
                else if (grid[XI, YI] == 9)
                {
                    Console.WriteLine(string.Format("{0} {1}", XI, ++YI));
                    continue;
                }
                else if (grid[XI, YI] == 10)
                {
                    Console.WriteLine(string.Format("{0} {1}", --XI, YI));
                    continue;
                }
                else if (grid[XI, YI] == 11)
                {
                    Console.WriteLine(string.Format("{0} {1}", ++XI, YI));
                    continue;
                }
                else if (grid[XI, YI] == 12)
                {
                    Console.WriteLine(string.Format("{0} {1}", XI, ++YI));
                    continue;
                }
                else if (grid[XI, YI] == 13)
                {
                    Console.WriteLine(string.Format("{0} {1}", XI, ++YI));
                    continue;
                }

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");

                // One line containing the X Y coordinates of the room in which you believe Indy will be on the next turn.
                //Console.WriteLine("0 0");
            }
        }
    }
}
