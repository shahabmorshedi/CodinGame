using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.STOCK_EXCHANGE_LOSSES
{
    public class STOCK_EXCHANGE_LOSSES
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int P = 0;
            int v = int.Parse(inputs[0]);
            for (int i = 1; i < n; i++)
                if (int.Parse(inputs[i]) >= v)
                    v = int.Parse(inputs[i]);
                else if (int.Parse(inputs[i]) < v && (int.Parse(inputs[i]) - v) < P)
                    P = int.Parse(inputs[i]) - v;

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(P);
        }
    }
}

