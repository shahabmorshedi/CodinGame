using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodinGame
{
    class tttttttttt
    {
        static void Main(string[] args)
        {

            string txt = File.ReadAllText(@"E:\Source\Theme\Test2.html");
            string id = "";
            while (txt.Contains("title"))
            {
                txt = txt.Substring(txt.IndexOf("title")+7);
                id += $"insert into Following(UserName,AccountID,FollowDate)values('{ txt.Substring(0, txt.IndexOf("\""))}',3,'{DateTime.Now.AddDays(-10)}')\r\n";
            }


            Console.WriteLine(id);
            Console.ReadLine();
        }
    }
}
