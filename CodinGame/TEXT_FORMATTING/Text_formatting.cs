using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.TEXT_FORMATTING
{
    class Text_formatting
    {

        static void Main(string[] args)
        {
            string intext = "one , TWO  ,,  three  ..  four,fivE , six .";
            //string intext = "when a father gives to his son,   , ., Both laugh; When a son gives to his father     , , , Both cry...   shakespeare";
            //string z =      "When a father gives to his son, both laugh; when a son gives to his father, both cry. Shakespeare";
            
            string solution = "";
            intext = intext.Trim().TrimStart('.', ',').ToLower();
            char t = intext[0];
            for (int i = 0; i < intext.Length; i++)
            {
                t = intext[i];
                if (!((t > 96 && t < 123) || (t > 64 && t < 91) || (t > 47 && t < 58)) && solution[solution.Length - 1] == t)
                {
                    continue;
                }
                if (!((t > 96 && t < 123) || (t > 64 && t < 91) || (t > 47 && t < 58)) && solution[solution.Length - 1] != ' ' &&
                    !((solution[solution.Length - 1] > 96 && solution[solution.Length - 1] < 123) || (solution[solution.Length - 1] > 64 && t < 91) || (solution[solution.Length - 1] > 47 && solution[solution.Length - 1] < 58)))
                {
                    continue;
                }
                if (i == 0 || ((t > 96 && t < 123) && (solution[solution.Length - 1] == '.')))
                {
                    t = Convert.ToChar(intext[i] - 32);
                }
                if (solution.Length > 0 && solution[solution.Length - 1] != ' ' && !((solution[solution.Length - 1] > 96 && solution[solution.Length - 1] < 123) || (solution[solution.Length - 1] > 64 && solution[solution.Length - 1] < 91) || (solution[solution.Length - 1] > 47 && solution[solution.Length - 1] < 58)))
                {
                    solution += ' ';
                }
                if (!((t > 96 && t < 123) || (t > 64 && t < 91) || (t > 47 && t < 58)) && solution[solution.Length - 1] == ' ')
                {
                    solution = solution.Substring(0, solution.Length - 1) + t;
                    continue;
                }
                solution += t;
            }

            Console.WriteLine(solution);
            Console.ReadLine();
        }
    }
}