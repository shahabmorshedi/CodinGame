using System;
using System.Linq;
using System.Collections.Generic;

class sl1
{
    static void Main(string[] args)
    {
        var tiles = new[] { "000", "BBB", "0RL0", "B00", "L0B", "RB0", "0RL", "B0B", "0BB", "BB0", "L00", "R00", "00B", "0B0" };
        var dirs = new[] { "TOP", "LEFT", "RIGHT" };

        var inputs = Console.ReadLine().Split(' ');
        var W = int.Parse(inputs[0]);
        var H = int.Parse(inputs[1]);
        var grid = Enumerable.Range(0, H).Select(_ => Console.ReadLine().Split(' ').Select(int.Parse).ToArray()).ToArray();
        var EX = int.Parse(Console.ReadLine()); // the coordinate along the X axis of the exit (not useful for this first mission, but must be read).

        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            var XI = int.Parse(inputs[0]);
            var YI = int.Parse(inputs[1]);
            var POS = inputs[2];
            var tile = grid[YI][XI];
            var dir = dirs.TakeWhile(x => x != POS).Count();
            var result = tiles[tile][dir];
            switch (result)
            {
                case 'L': XI--; break;
                case 'R': XI++; break;
                case 'B': YI++; break;
            }
            Console.WriteLine($"{XI} {YI}");
        }
    }
}