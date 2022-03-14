using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0106
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10,10];
            for(int i = 0; i <= array.GetUpperBound(1); i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
                    }
                }
            }

            for(int i = 0; i < 10; i++)
            {
                for(int j = i + 1; j < 10; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i + 1;j++)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
