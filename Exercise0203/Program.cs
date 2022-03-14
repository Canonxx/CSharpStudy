using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0203
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Int32> ls = new List<int>();
            List<Int32> ls1 = new List<Int32>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                ls.Add(r.Next());
            }
            foreach (Int32  item in ls)
            {
                if (item%2==1)
                {
                    ls1.Add(item);
                }
            }
            foreach (Int32 item in ls1)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }
    }
}
