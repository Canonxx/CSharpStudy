using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0107
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = { 20, 16, 78, 61, 12, 99, 57, 34, 8 };
            Sort(numList);
            foreach (int item in numList)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }

        public static void Sort(int[] list)
        {
            for(int i = 0; i < list.Length - 1; i++)
            {
                for(int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] > list[j])
                    {
                        int tmp;
                        tmp = list[i];
                        list[i] = list[j];
                        list[j] = tmp;
                    }
                }
            }
        }
    }
}
