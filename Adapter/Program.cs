using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本用法（Basic.cs）
            Target target = new Adapter();
            target.Request(); 
            #endregion

            #region 具体实例（Example.cs）
            Player b = new Forwards("巴蒂尔");
            b.Attack();

            Player m = new Guards("麦克格雷迪");
            m.Attack();

            //Player ym = new Center("姚明");
            Player ym = new Translator("姚明");
            ym.Attack();
            ym.Defense();

            Console.Read(); 
            #endregion
        }
    }
}
