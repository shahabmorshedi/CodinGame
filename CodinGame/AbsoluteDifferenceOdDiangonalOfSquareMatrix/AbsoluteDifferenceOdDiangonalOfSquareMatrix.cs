using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.AbsoluteDifferenceOdDiangonalOfSquareMatrix
{
    public class AbsoluteDifferenceOdDiangonalOfSquareMatrix
    {
        public static void Main(string[] args)
        {
            int diagonal = int.Parse(Console.ReadLine());

            int[,] matrix = new int[diagonal, diagonal];

            for (int i = 0; i < diagonal; i++)
            {
                string[] r = Console.ReadLine().Split(' ');
                for (int j = 0; j < diagonal; j++)
                    matrix[i, j] = int.Parse(r[j]);
            }

            int d1 = 0;
            int d2 = 0;

            for (int i = 0; i < diagonal; i++)
                d1 += matrix[i, i];

            for (int i = diagonal - 1, j = 0; i >= 0; i--, j++)
                d2 += matrix[i, j];

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(Math.Abs(d1 - d2));
            Console.ReadLine();
        }
    }
}
