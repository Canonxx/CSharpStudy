using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0105
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum += Fib(i);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static int Fib(int n)
        {
            if (n <= 2)
                return 1;
            else
                return Fib(n-1)+Fib(n - 2);
        }
    }
}
