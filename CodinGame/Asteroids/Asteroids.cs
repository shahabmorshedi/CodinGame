using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Asteroids
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]);
        int H = int.Parse(inputs[1]);
        int T1 = int.Parse(inputs[2]);
        int T2 = int.Parse(inputs[3]);
        int T3 = int.Parse(inputs[4]);
        for (int i = 0; i < H; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            string firstPictureRow = inputs[0];
            string secondPictureRow = inputs[1];
        }
    }
}