using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0201
{
    class Magpie:Bird,IFlyable
    {
        public override void Eat()
        {
            Console.WriteLine("喜鹊喜欢吃虫子");
        }

        public void Fly()
        {
            Console.WriteLine("我可以飞");
        }
    }
}
