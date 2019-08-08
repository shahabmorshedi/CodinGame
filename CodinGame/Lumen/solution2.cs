using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CodinGame.Lumen
{
    class solution2
    {
        static int ReadIntValue() => int.Parse(Console.ReadLine());

        static void Main(string[] args)
        {
            // Resolve room dimension and candle strength
            int N = ReadIntValue(), L = ReadIntValue();

            // Prepare a dark room (with collapsed dimensions)
            var room = new int[N * N];

            // Define inline local function to set resolve lighting "box" for each candle
            Action<int, int> SetCandle = (int x, int y) =>
            {
                for (int i = Math.Max(0, x - L + 1); i < Math.Min(N, x + L); i++)
                    for (int j = Math.Max(0, y - L + 1); j < Math.Min(N, y + L); j++)
                        room[i + j * N] = 1;
            };

            // Resolve candles in the room
            for (int i = 0; i < N; i++)
            {
                Console.ReadLine().Split().Select((c, idx) => new { Index = idx, Value = c })
                    .Where(x => x.Value == "C").Select(x => x.Index)
                    .ToList().ForEach(x => SetCandle(x, i));
            }

            // Output number of black spots in the room by counting non-black spots
            Console.WriteLine(room.Count() - room.Sum());
        }
    }
}
