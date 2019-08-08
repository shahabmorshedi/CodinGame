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
class ShadowsOfTheKnightEpisode1
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

        int lowW = 0;
        int lowH = 0;
        int MaxW = W;
        int MaxH = H;

        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

            switch (bombDir)
            {
                case "U":
                    {
                        MaxH = Y0;
                        Y0 = (Y0 + lowH) / 2;
                        Console.WriteLine(string.Format("{0} {1}", X0, Y0));
                        break;
                    }
                case "UR":
                    {
                        lowW = X0;
                        MaxH = Y0;
                        Y0 = (Y0 + lowH) / 2;
                        X0 = (X0 + MaxW) / 2;
                        Console.WriteLine(string.Format("{0} {1}", X0, Y0));
                        break;
                    }
                case "R":
                    {
                        lowW = X0;
                        X0 = (X0 + MaxW) / 2;
                        Console.WriteLine(string.Format("{0} {1}", X0, Y0));
                        break;
                    }
                case "DR":
                    {
                        lowH = Y0;
                        lowW = X0;
                        Y0 = (Y0 + MaxH) / 2;
                        X0 = (X0 + MaxW) / 2;
                        Console.WriteLine(string.Format("{0} {1}", X0, Y0));
                        break;
                    }
                case "D":
                    {
                        lowH = Y0;
                        Y0 = (Y0 + MaxH) / 2;
                        Console.WriteLine(string.Format("{0} {1}", X0, Y0));
                        break;
                    }   
                case "DL":
                    {
                        lowH = Y0;
                        MaxW = X0;
                        Y0 = (Y0 + MaxH) / 2;
                        X0 = (X0 + lowW) / 2;
                        Console.WriteLine(string.Format("{0} {1}", X0, Y0));
                        break;
                    }
                case "L":
                    {
                        MaxW = X0;
                        X0 = (X0 + lowW) / 2;
                        Console.WriteLine(string.Format("{0} {1}", X0, Y0));
                        break;
                    }
                case "UL":
                    {
                        MaxH = Y0;
                        MaxW = X0;
                        X0 = (X0 + lowW) / 2;
                        Y0 = (Y0 + lowH) / 2;
                        Console.WriteLine(string.Format("{0} {1}", X0, Y0));
                        break;
                    }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            // the location of the next window Batman should jump to.

        }
    }
}