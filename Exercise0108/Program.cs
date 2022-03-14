using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0108
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "  Hello   World  !   你好    世界 ！ ";
            str = str.Trim();
            string str1=null;
            String[] array = str.Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);
            foreach (String item in array)
            {
                str1 =str1+ item+" ";
            }
            Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
