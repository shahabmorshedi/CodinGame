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
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            string operands = "+-*/";

            string left = expression.Split('=')[0];
            int right = int.Parse(expression.Split('=')[1]);
            List<string> equation = new List<string>();

            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] == ' ')
                    continue;

                string digit = "";
                if (!operands.Contains(left[i]))
                {
                    digit += left[i];
                }
                else
                {
                    equation.Add(digit);
                    equation.Add(left[i].ToString());
                }
            }

            int result = 0;
            while (result != right)
            {
                for (int i = 0; i < equation.Count; i++)
                {
                    if (!operands.Contains(left[i]))
                    {
                        if (equation[i].Contains('?'))
                        {
                        }
                    }
                }
            }


            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("answer");
        }
    }
}