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
class ShadowsOfTheKnightEpisode2
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);

        int px = X0;
        int py = Y0;
        int lowW = 0;
        int lowH = 0;
        int MaxW = W - 1;
        int MaxH = H - 1;
        bool s = true;
        int z = 0;

        Console.Error.WriteLine($"W:{W}");
        Console.Error.WriteLine($"H:{H}");
        Console.Error.WriteLine($"N:{N}");
        Console.Error.WriteLine($"X0:{X0}");
        Console.Error.WriteLine($"Y0:{Y0}");

        //string bombDir = Console.ReadLine(); // Current distance to the bomb compared to previous distance (COLDER, WARMER, SAME or UNKNOWN)
        string bombDir = "";
        // game loop
        while (true)
        {
            if (bombDir.Length > 1)
            {
                double a1 = Math.Sqrt(Math.Pow((4 - X0), 2) + Math.Pow((10 - Y0), 2));
                double a2 = Math.Sqrt(Math.Pow((4 - px), 2) + Math.Pow((10 - py), 2));
                if (a1 > a2)
                {
                    bombDir = "COLDER";
                }
                else if (a1 < a2)
                {
                    bombDir = "WARMER";
                }
                else if (a1 == a2)
                {
                    bombDir = "SAME";
                }
            }
            else
            {
                bombDir = "UNKNOWN";
            }

            switch (bombDir)
            {
                case "COLDER":
                    {
                        s = !s;
                        if (s)
                        {
                            if (Y0 >= (MaxH + lowH) / 2)
                                lowH = (MaxH + lowH) / 2;
                            else
                                MaxH = (MaxH + lowH) / 2;

                            X0 = px;
                            if (Y0 > py)
                            {
                                Y0 = py - 1;
                            }
                            else
                            {
                                Y0 = py + 1;
                            }
                        }
                        else
                        {
                            if (X0 >= (MaxW + lowW) / 2)
                                lowW = (MaxW + lowW) / 2;
                            else
                                MaxW = (MaxW + lowW) / 2;
                            Y0 = py;
                            if (X0 > px)
                            {
                                X0 = px - 1;
                            }
                            else
                            {
                                X0 = px + 1;
                            }
                        }
                        s = !s;
                        break;
                    }
                case "WARMER":
                    {
                        px = X0;
                        py = Y0;
                        if (s)
                        {
                            if (X0 >= (MaxW + lowW) / 2)
                                lowW = (MaxW + lowW) / 2;
                            else
                                MaxW = (MaxW + lowW) / 2;

                            if (Y0 >= (MaxH + lowH) / 2)
                            {
                                Y0 = (((lowH + MaxH) / 2) + lowH) / 2;
                            }
                            else if (Y0 < (MaxH + lowH) / 2)
                            {
                                Y0 = ((MaxH / 2) + MaxH) / 2;
                            }
                        }
                        else
                        {
                            if (Y0 >= (MaxH + lowH) / 2)
                                lowH = (MaxH + lowH) / 2;
                            else
                                MaxH = (MaxH + lowH) / 2;

                            if (X0 >= (MaxW + lowW) / 2)
                            {
                                X0 = ((MaxW / 2) + lowW) / 2;
                            }
                            else if (X0 < (MaxW + lowW) / 2)
                            {
                                X0 = ((MaxW / 2) + MaxW) / 2;
                            }
                        }
                        s = !s;
                        break;
                    }
                case "SAME":
                    {
                        int a = X0;
                        int b = Y0;
                        if (s)
                        {
                            if (X0 > px)
                                MaxW = X0;
                            else
                                MaxW = px;

                            X0 = (X0 + px) / 2;
                        }
                        else
                        {
                            if (Y0 > py)
                                MaxH = Y0;
                            else
                                MaxH = py;

                            Y0 = (Y0 + py) / 2;
                        }
                        px = a;
                        py = b;
                        break;
                    }
                default:
                        {
                        px = X0;
                        py = Y0;
                        if (Y0 >= (MaxH + lowH) / 2)
                        {
                            Y0 = ((MaxH / 2) + lowH) / 2;
                        }
                        else if (Y0 < (MaxH + lowH) / 2)
                        {
                            Y0 = ((MaxH / 2) + MaxH) / 2;
                        }
                        s = !s;
                        break;
                    }
            }

            Console.WriteLine($"{X0} {Y0}");

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
        }

        Console.ReadLine();
    }
}