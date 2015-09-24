using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本用法（Basic.cs）
            Proxy proxy = new Proxy();
            proxy.Request(); 
            #endregion

            #region 具体实例（Example.cs）
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "李娇娇";

            PursuitProxy daili = new PursuitProxy(jiaojiao);
            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveChocolate(); 
            #endregion

            Console.Read();
        }
    }
}
