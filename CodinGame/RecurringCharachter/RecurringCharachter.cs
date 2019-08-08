using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.RecurringCharachter
{

    //Write a program that returns first recurring charachters of a string.

    class RecurringCharachter
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();

            //solution1 O(n^2)
            //for (int i = 0; i < Input.Length - 1; i++)
            //    for (int j = i + 1; j < Input.Length; j++)
            //        if (Input[i] == Input[j])
            //            Console.WriteLine(Input[j]);

            //solution2 O(n)
            for (int i = 1; i < Input.Length; i++)
                if (Input.Substring(0, i).Contains(Input[i]))
                    Console.WriteLine(Input[i]);

        }
    }
}
