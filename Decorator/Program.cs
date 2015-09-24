using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本用法（对应Basic.cs）
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();
            #endregion

            #region 具体实例（对应Example.cs）
            Person xc = new Person("小菜");
            Console.WriteLine("\n第一种装扮：");

            Sneaker pqx = new Sneaker();
            BigTrouser kk = new BigTrouser();
            TShirt dtx = new TShirt();

            pqx.Decorate(xc);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();

            Console.WriteLine("\n第二种装扮：");

            LeatherShoes px = new LeatherShoes();
            Tie ld = new Tie();
            Suit xz = new Suit();

            px.Decorate(xc);
            ld.Decorate(px);
            xz.Decorate(ld);
            xz.Show();

            Console.ReadLine();
            #endregion
        }
    }
}
