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
class ChessBoardAnalyzer
{
    static void Main(string[] args)
    {
        string R, N, B, Q, K, P, r, n, b, q, k;

        for (int i = 0; i < 8; i++)
        {
            string boardRow = Console.ReadLine();
            for (int j = 0; j < boardRow.Length; j++)
            {
                string p;
                if (boardRow[j] == 'R')
                    R = $"{i} {j}";
                else if (boardRow[j] == 'N')
                    N = $"{i} {j}";
                else if (boardRow[j] == 'B')
                    B = $"{i} {j}";
                else if (boardRow[j] == 'Q')
                    Q = $"{i} {j}";
                else if (boardRow[j] == 'K')
                    K = $"{i} {j}";
                else if (boardRow[j] == 'P')
                    P = $"{i} {j}";
                else if (boardRow[j] == 'r')
                    r = $"{i} {j}";
                else if (boardRow[j] == 'n')
                    n = $"{i} {j}";
                else if (boardRow[j] == 'b')
                    b = $"{i} {j}";
                else if (boardRow[j] == 'q')
                    q = $"{i} {j}";
                else if (boardRow[j] == 'k')
                    k = $"{i} {j}";
                else if (boardRow[j] == 'p')
                    p = $"{i} {j}";
            }
        }

        while (true)
        {

        }


        //int Ki = int.Parse(K.Split(' ')[0]);
        //int Kj = int.Parse(K.Split(' ')[1]);





        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine("boardStateChar");
    }
}