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
class BRACKETS_EXTREME_EDITION
{
    static void Main(string[] args)
    {
        string expression = Console.ReadLine();
        int z = 0;
        foreach (char c in expression)
            if (z < 0) break;
            else if (c == '{') z += 1;
            else if (c == '(') z += 2;
            else if (c == '[') z += 3;
            else if (c == '}') z -= 1;
            else if (c == ')') z -= 2;
            else if (c == ']') z -= 3;



        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(z == 0 ? "true" : "false");

    }
}