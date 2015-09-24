using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// 正常收费
    /// </summary>
    class CashNormal:CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
