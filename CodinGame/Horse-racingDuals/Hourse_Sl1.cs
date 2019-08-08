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
 * https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k(System.Linq.Enumerable.Zip``3);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5.2);k(DevLang-csharp)&rd=true
 **/
class Hourse_Sl1
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<int> pi = new List<int>();
        for (int i = 0; i < N; i++)
            pi.Add(int.Parse(Console.ReadLine()));

        int minDelta = pi.OrderByDescending(x => x).Zip(pi.OrderByDescending(x => x).Skip(1), (current, next) => current - next).Min();

        Console.WriteLine(minDelta);
    }
}