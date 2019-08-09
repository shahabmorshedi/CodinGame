using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//((
//sdsfd;)         
//    (        sdasdasd
//    );
//    (
//        'sad  asdasd'
//)(
//        'asd'='a';
//        'asd'=adadasd
//))

namespace CodinGame.CGX_Formatter
{
    class CGXFormatter
    {
        static void Main(string[] args)
        {
            string cgx = "";

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string cgxLine = Console.ReadLine();
                cgx += cgxLine;
            }

            int col = 0;
            string result = "";
            bool VALUE_KEY = false;

            for (int i = 0; i < cgx.Length; i++)
            {
                if (cgx[i] == '(')
                {
                    if (VALUE_KEY)
                    {
                        result += Environment.NewLine;
                        VALUE_KEY = false;
                    }

                    result += new String(' ', col);
                    result += $"({Environment.NewLine}";
                    col += 4;
                }
                else if (cgx[i] == ')')
                {
                    bool z = true;
                    int n = i - 1;
                    while (true)
                    {
                        if (cgx[n] == '(' || cgx[n] == ';')
                        {
                            z = false;
                            break;
                        }
                        else if (cgx[n] == 32)
                        {
                            n--;
                            continue;
                        }
                        else
                            break;
                    }

                    if (z)
                        result += $"{Environment.NewLine}";

                    col -= 4;
                    result += $"{new String(' ', col)})";
                }
                else
                {
                    if (cgx[i] == 32)
                        continue;
                    else
                    {
                        if (cgx[i] == '\'')
                        {
                            if (VALUE_KEY == false)
                            {
                                result += new String(' ', col);
                                VALUE_KEY = true;
                            }

                            do
                            {
                                result += cgx[i].ToString();
                            } while (cgx[++i] != '\'');
                            result += cgx[i].ToString();
                            continue;
                        }
                        else if (cgx[i] == '=')
                        {
                            result += cgx[i];
                            VALUE_KEY = true;
                            continue;
                        }
                        else if (cgx[i] == ';')
                        {
                            result += $";{Environment.NewLine}";
                            VALUE_KEY = false;
                        }
                        else
                        {
                            if (VALUE_KEY == false)
                            {
                                result += new String(' ', col);
                                VALUE_KEY = true;
                            }

                            while (true)
                            {
                                result += cgx[i].ToString();
                                if (i < cgx.Length - 1 && cgx[i + 1] != ';' && cgx[i + 1] != ')' && cgx[i + 1] != 32)
                                    i++;
                                else
                                    break;
                            }
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine($"{result.Trim()}");
            Console.ReadLine();
        }
    }
}