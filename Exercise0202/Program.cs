using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0202
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1 2 3 4 5 6 7 8 9 10";
            string[] intArray = str.Split(' ');
            List<Int32> ls1 = new List<Int32>();
            foreach (string item in intArray)
            {
                if (Convert.ToInt32(item) % 2 == 1)
                {
                    ls1.Add(Convert.ToInt32(item));
                }
            }
            foreach (String item in intArray)
            {
                if (Convert.ToInt32(item) % 2 == 0)
                {
                    ls1.Add(Convert.ToInt32(item));
                }
            }
            foreach (int item in ls1)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }
    }
}
