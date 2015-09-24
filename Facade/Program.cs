using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本用法（对应Basic.cs）
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
            #endregion

            #region 具体实例（对应Example.cs）
            Fund jijin = new Fund();

            jijin.BuyFund();
            jijin.SellFund();

            Console.Read(); 
            #endregion
        }
    }
}
