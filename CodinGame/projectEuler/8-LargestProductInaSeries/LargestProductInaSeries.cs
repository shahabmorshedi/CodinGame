using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace projectEuler._8_LargestProductInaSeries
{
    class LargestProductInaSeries
    {
        public static void Main(string[] args)
        {
            string serie = "";
            using (FileStream fs = new FileStream(@"E:\Source\CodinGame\CodinGame\projectEuler\8-LargestProductInaSeries\serie.txt", FileMode.Open))
            {
                byte[] buffer = new byte[fs.Length];
                while (fs.Read(buffer, 0, buffer.Length) > 0)
                {
                    serie += Encoding.UTF8.GetString(buffer);
                }
            }

            serie = serie.Replace("\r\n", "");
            int max = 0;
            for (int i = 0; i < serie.Length - 12; i++)
            {
                string foobar = serie.Substring(i, 13);
                if (foobar.Contains("0"))
                    continue;
                int product = 1;
                for (int j = 0; j < foobar.Length; j++)
                {
                    int a = int.Parse(foobar[j].ToString());
                    product *= a;
                }
                if (max < product)
                    max = product;
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}