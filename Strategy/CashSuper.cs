using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// 现金收取父类
    /// </summary>
    abstract class CashSuper
    {
        /// <summary>
        /// 收取现金
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns>当前价</returns>
        public abstract double acceptCash(double money); 
    }
}
