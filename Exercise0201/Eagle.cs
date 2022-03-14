using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0201
{
    class Eagle:Bird,IFlyable
    {
        public override void Eat()
        {
            Console.WriteLine("老鹰喜欢吃肉");
        }

        public void Fly()
        {
            Console.WriteLine("我可以飞");
        }
    }
}
