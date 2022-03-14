using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0201
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用抽象类
            Bird[] arrays = new Bird[] {new Magpie(),new Eagle(),new Penguin() };
            Duck[] b1 = new Duck[] { new RubberDuck(), new WoodDuck(), new RealDuck() };
            foreach (Bird item in arrays)
            {
                item.Eat();
                Console.WriteLine();
            }
            //类型转换
            ((Magpie)arrays[0]).Fly();
            ((Eagle)arrays[1]).Fly();

            foreach (Duck item in b1)
            {
                item.swim();
            }
            ((RubberDuck)b1[0]).Shout();
            ((RealDuck)b1[2]).Shout();
            Console.ReadKey();
        }

    }
}
