using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.CGX_Formatter
{
    class CGXFormatter
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            //string cGXLine = "";
            //for (int i = 0; i < N; i++)
            //{
            //    cGXLine += Console.ReadLine().Replace("\r", "").Replace("\n", "").Replace("\\13", "");
            //}

            string cGXLine = "(    'menu'=    (        'id'= 'file';        'value'= 'File';        'popup'=        (            'menuitem'=            (                ( 'value'= 'New'; 'onclick'= 'CreateNewDoc()' );                ( 'value'= 'Open'; 'onclick'= 'OpenDoc()' );                ( 'value'= 'Close'; 'onclick'= 'CloseDoc()' )            )        ); ()    ))";
            //string cGXLine = "'users' = (('id' = 10;            'name' = 'Serge';            'roles' = ('visitor';            'moderator'));            ('id' = 11;            'name' = 'Biales');            true)";

            int s = 0;
            int e = 0;
            string result = "";
            while (true)
            {
                e = cGXLine.IndexOf('\'');
                result += cGXLine.Substring(s, e);
                if (e > 0)
                {
                    //cGXLine.Substring( cGXLine.Substring(e).IndexOf('\'');
                }


                break;
            }



            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            //Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
