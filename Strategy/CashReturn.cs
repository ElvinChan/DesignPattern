using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// 返利收费
    /// </summary>
    class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moneyCondition">返利条件</param>
        /// <param name="moneyReturn">返利值</param>
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        public override double acceptCash(double money)
        {
            double result = money;
            //大于返利条件，需要减去
            if (money >= moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }
}
