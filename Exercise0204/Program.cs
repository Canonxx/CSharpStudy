using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0204
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Int32, char> dict1 = new Dictionary<Int32, char>();
            dict1.Add(0, '零');
            dict1.Add(1, '壹');
            dict1.Add(2, '贰');
            dict1.Add(3, '叁');
            dict1.Add(4, '肆');
            dict1.Add(5, '伍');
            dict1.Add(6, '陆');
            dict1.Add(7, '柒');
            dict1.Add(8, '捌');
            dict1.Add(9, '玖');
            Console.Write("请输入：");
            string str = Console.ReadLine();
            foreach (char item in str)
            {
                Console.Write(dict1[Convert.ToInt32(item)-48]);
            }
            Console.ReadKey();
        }
    }
}
