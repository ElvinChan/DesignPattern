using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本用法（Basic.cs）
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            s.SubjectState = "ABC";
            s.Notify();
            #endregion

            #region 具体实例（Example.cs）
            //相比于基本用法，这个实例：
            //①进一步将通知者和观察者分离，运用依赖倒转原则，在客户端中将观察者动作委托给通知者，进一步降低了耦合
            //②观察者实例无需继承观察者接口

            Boss huhanshan = new Boss();

            StockObserver tongshi1 = new StockObserver("魏关姹", huhanshan);
            NBAOberver tongshi2 = new NBAOberver("易管查", huhanshan);

            huhanshan.Update += new EventHandler(tongshi1.CloseStockMarket);
            huhanshan.Update += new EventHandler(tongshi2.CloseNBADirectSeeding);

            huhanshan.SubjectState = "我胡汉三回来了";
            huhanshan.Notify();

            Console.Read(); 
            #endregion
        }
    }
}
