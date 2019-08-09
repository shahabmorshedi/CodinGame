using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.Thor
{
    class Thor
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int LX = int.Parse(inputs[0]); // the X position of the light of power
            int LY = int.Parse(inputs[1]); // the Y position of the light of power
            int TX = int.Parse(inputs[2]); // Thor's starting X position
            int TY = int.Parse(inputs[3]); // Thor's starting Y position

            // game loop
            while (true)
            {
                int remainingTurns = int.Parse(Console.ReadLine()); // The level of Thor's remaining energy, representing the number of moves he can still make.

                Console.WriteLine("SE");
            }
        }
    }
}
