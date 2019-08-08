using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.Highest_truncated_pyramid
{
    //You will be given a integer N, your goal is to draw the highest truncated pyramid that contains N “bricks”.
    //Each floor of a pyramid contains one brick more than the previous one.
    //Each brick is a* and each floor begins at the left of the line.
    //Be careful not to add spaces at the end of a line.

    public class Highest_Truncated_Pyramid
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int f = 1;
            int c = 1;
            //Console.Error.WriteLine(N);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < f && c <= N; j++, c++, Console.Write("*")) ;
                f++;
                if (c <= N)
                    Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
