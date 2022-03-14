using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0205
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict1 = new Dictionary<string,int>();
            dict1.Add("零",0);
            dict1.Add("一",1);
            dict1.Add("二", 2);
            dict1.Add("三", 3);
            dict1.Add("四", 4);
            dict1.Add("五", 5);
            dict1.Add("六", 6);
            dict1.Add("七", 7);
            dict1.Add("八", 8);
            dict1.Add("九", 9);
            string str = "二零二二年十一月十五日";
            string[] strarray = str.Split(new char[] { '年', '月', '日' });
            string str1 = null;
            
            foreach ( char item in strarray[0])
            {
                str1 += dict1[item.ToString()];
            }
            str1 += '-';
            if(!strarray[1].Contains('十'))
            {
                foreach (char item in strarray[1])
                {
                    str1 += dict1[item.ToString()];
                }
                str1 += '-';
            }
          
            if (strarray[1].Contains('十'))
            {
                if (strarray[1].Length == 1)
                    str1 += 10;
                else if (strarray[1].Length==2 && strarray[1].Substring(0,1)=="十")
                {
                    str1 = str1 + 1 + dict1[strarray[1].Substring(1, 1)];
                }
                else if(strarray[1].Length == 2 && strarray[1].Substring(1, 1) == "十")
                {
                       str1 = str1+10* dict1[strarray[1].Substring(1, 1)];
                }
                else if (strarray[1].Length == 3)
                {
                    str1 = str1 + dict1[strarray[1][0].ToString()] * 10 + dict1[strarray[1][2].ToString()];
                }
                str1 += '-';
            }

            if (!strarray[2].Contains('十'))
            {
                foreach (char item in strarray[1])
                {
                    str1 += dict1[item.ToString()];
                }
                str1 += '-';
            }

            if (strarray[2].Contains('十'))
            {
                if (strarray[2].Length == 1)
                    str1 += 10;
                else if (strarray[2].Length == 2 && strarray[2].Substring(0, 1) == "十")
                {
                    str1 = str1 + 1 + dict1[strarray[2].Substring(1, 1)];
                }
                else if (strarray[2].Length == 2 && strarray[2].Substring(1, 1) == "十")
                {
                    str1 = str1 + 10 * dict1[strarray[2].Substring(1, 1)];
                }
                else if (strarray[2].Length == 3)
                {
                    str1 = str1 + dict1[strarray[2][0].ToString()] * 10 + dict1[strarray[2][2].ToString()];
                }
                
            }
            Console.WriteLine(str1);
            Console.ReadKey();

        }
    }
}
