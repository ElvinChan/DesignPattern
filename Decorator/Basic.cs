using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    //定义一个对象接口，可以给这些对象动态地添加职责
    abstract class Component
    {
        public abstract void Operation();
    }

    //定义了一个具体的对象，也可以给这个对象添加一些职责
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }

    //装饰抽象类，从外类来扩展Component类的功能
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component !=null)
            {
                component.Operation();
            }
        }
    }

    //具体的装饰对象，起到给Component添加职责的功能
    class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");
        }

        private void AddedBehavior()
        {
 
        }
    }
}
