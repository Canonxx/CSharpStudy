using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0201
{
    class RealDuck : Duck, IShoutable
    {
        public void Shout()
        {
            Console.WriteLine("我会嘎嘎叫");
        }

        public override void swim()
        {
            Console.WriteLine("我会游泳");
        }
    }
}
