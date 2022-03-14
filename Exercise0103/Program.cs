using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0103
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "患者：“大夫，我咳嗽得很重。”     " +
                         "大夫：“你多大年记？”     " +
                         "患者：“七十五岁。”    " +
                         "大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     " +
                         "大夫：“四十岁时咳嗽吗？”     " +
                         "患者：“也不咳嗽。”    " +
                         " 大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            int[] list = new int[10];
            int count = 0;
            bool flag = false;
            int index = 0;
            foreach (char item in str)
            {
                if (item == '咳')
                    flag = true;
                else if (flag && item == '嗽') {
                    list[count] = str.IndexOf('咳',index);
                    index = list[count] + 1;
                    count++;
                }
                else
                    flag = false;  
            }
            Console.WriteLine(count);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
