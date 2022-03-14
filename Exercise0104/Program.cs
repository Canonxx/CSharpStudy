using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0104
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "2020年10月1日";
            String year=null;
            String month= null;
            String day=null;
            int index = 0;
            char[] charStr = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (charStr[i] == '年')
                {
                    index = i;
                    year = str.Substring(0,i);
                }
                else if (charStr[i]=='月')
                {
                    month = str.Substring(index + 1, i - index - 1);
                    index = i;
                }
                else
                {
                    day = str.Substring(index + 1,str.Length-1-index-1);
                }
            }
            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(day);
            Console.ReadKey();
        }
    }
}
