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
 * The program:
   You are given an expression comprised of integers separated by operators, as well as the result of the expression preceded by an equals symbol =.
   However, some of the digits in the expression have been replaced by question marks ?. 
   You must restore the missing digits to the expression in such a way that it stays correct.

   The digits to the right of the equals sign = will never be replaced by question marks ? .

   Each expression can have several operators, but of the same type only.
 * 
 **/

namespace CodinGame.Mystery_sums
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            if (!expression.Contains("?"))
                Console.WriteLine(expression);
            else
            {
                int result = int.Parse(expression.Split('=')[1].Trim());
                string[] ex = expression.Split('=')[0].Split(' ');
                List<string> x = new List<string>();
                List<int> n = new List<int>();
                List<string> o = new List<string>();

                for (int i = 0; i < ex.Length; i++)
                {
                    int zint = 0;

                    if (ex[i].Contains("?"))
                    {
                        x.Add(ex[i]);
                    }
                    else if (int.TryParse(ex[i], out zint))
                    {
                        n.Add(zint);
                    }
                    else if (ex[i] == "+" || ex[i] == "-" || ex[i] == "*" || ex[i] == "/")
                    {
                        o.Add(ex[i]);
                    }
                }

                foreach (string op in o)
                {
                    if (op == "+")
                        if (result == (result - n[0]) + n[0])
                            Console.WriteLine("{0} {1} {2} = {3}", (result - n[0]), o[0], n[0], result);


                }

            }
        }
    }
}