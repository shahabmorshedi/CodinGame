using static System.Console;
using static System.Math;


namespace CodinGame.Lumen
{
    class solution3
    {
        static void Main()
        {
            int N = int.Parse(ReadLine());
            int L = int.Parse(ReadLine());
            bool[,] light = new bool[N, N];
            int dark = N * N;
            for (int yc = 0; yc < N; yc++)
            {
                string line = ReadLine();
                for (int xc = 0; xc < N; xc++)
                    if (line[2 * xc] == 'C')
                        for (int x = Max(0, xc - L + 1); x < Min(N, xc + L); x++)
                            for (int y = Max(0, yc - L + 1); y < Min(N, yc + L); y++)
                            {
                                if (!light[x, y])
                                    dark--;
                                light[x, y] = true;
                            }
            }
            WriteLine(dark);
        }
    }
}
