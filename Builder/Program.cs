using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Program
    {
        //建造者模式：主要用于创建一些复杂的对象，这些对象内部构建间的建造顺序通常是稳定的，但对象内部的构建通常面临着复杂的变化
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.Read();
        }
    }

    //指挥者类，按照用户需求构建产品实例
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
        }
    }

    //抽象建造者类
    abstract class Builder
    {
        public abstract void BuilderPartA();
        public abstract void BuilderPartB();
        public abstract Product GetResult();
    }

    //具体建造者类，理解成工厂（创建产品实例→添加产品属性→返回产品对象）
    class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();

        public override void BuilderPartA()
        {
            product.Add("部件A");
        }

        public override void BuilderPartB()
        {
            product.Add("部件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();

        public override void BuilderPartA()
        {
            product.Add("部件X");
        }

        public override void BuilderPartB()
        {
            product.Add("部件Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    //产品类
    class Product
    {
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n产品 创建 ----");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
