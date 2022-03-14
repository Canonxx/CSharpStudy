using System;

namespace EXercise0102
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = Max(1,2,3,4,5,6);
            Console.WriteLine("maxNum={0}",maxNum);
        }
        static int Max(params int[] array)
        {
            int max=0;
            foreach (int i in array)
            {
                max = i;
                if (max <= i)
                    max = i;
            }
            return max;
        }
    }
}
