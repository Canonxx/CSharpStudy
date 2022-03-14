using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class Exercise0101
    {
        public static void Main(string[] args)
        {
            int m = 10,n = 20;
            int tmp;
            tmp = m;
            m = n;
            n = tmp;
            Console.WriteLine("m = {0},n = {1}",m,n);
            swap(ref m, ref n);
            Console.WriteLine("m = {0},n = {1}", m, n);
            int p = 5, q = 4;
            p = p - q;
            q = p + q;
            p = q - p;
            Console.WriteLine("p = {0},q = {1}", p, q);
            void swap(ref int m, ref int n)
            {
                int tmp = m;
                m = n;
                n = tmp;
            }
        }

        

    }
}
