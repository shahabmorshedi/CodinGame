using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * 
 * int.MaxValue is the greatest int. In my code it represents positive infinity as the first value of the projected sequence (the differences). 
 * It will be always discarded as long as there are at least 2 elements in the input sequence, since I look for the least difference. 
 * I could have coded a cleaner solution with a resulting projection of the n-1 differences alone, but I'm too lazy :)
 * 
 * https://msdn.microsoft.com/en-us/library/bb534869.aspx
 **/
class Hourse_Sl2
{
    static void Main(string[] args)
    {
        List<int> strengths = Enumerable.Range(0, int.Parse(Console.ReadLine())).Select(i => int.Parse(Console.ReadLine())).OrderBy(i => i).ToList();
        Console.WriteLine(strengths.Select((i, index) => index > 0 ? i - strengths[index - 1] : int.MaxValue).Min());
    }
}