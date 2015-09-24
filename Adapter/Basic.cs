using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求");
        }
    }

    //需要适配的类
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求");
        }
    }

    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        //表面上调用Request方法，实际是调用需要适配的类的SpecificRequest方法
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
