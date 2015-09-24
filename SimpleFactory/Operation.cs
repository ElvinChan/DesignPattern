using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            return 0;
        }

        public static string checkNumberInput(string currentNumber, string inputString)
        {
            string result = "";
            if (inputString == ".")
            {
                if (currentNumber.IndexOf(".") < 0)
                {
                    if (currentNumber.Length == 0)
                    {
                        result = "0" + inputString;
                    }
                    else
                    {
                        result = currentNumber + inputString;
                    }
                }
            }
            else if (currentNumber == "0")
            {
                result = inputString;
            }
            else
            {
                result = currentNumber + inputString;
            }
            return result;
        }
    }

    /// <summary>
    /// 加法类
    /// </summary>
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    /// <summary>
    /// 减法类
    /// </summary>
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    /// <summary>
    /// 乘法类
    /// </summary>
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    /// <summary>
    /// 除法类
    /// </summary>
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0");
            }
            result = NumberA / NumberB;
            return result;
        }
    }

    /// <summary>
    /// 平方类
    /// </summary>
    class OperationSqr : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberB * NumberB;
            return result;
        }
    }

    /// <summary>
    /// 平方根类
    /// </summary>
    class OperationSqrt : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB < 0)
            {
                throw new Exception("负数不能开平方根");
            }
            result = Math.Sqrt(NumberB);
            return result;
        }
    }

    /// <summary>
    /// 相反数类
    /// </summary>
    class OperationReverse : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = -NumberB;
            return result;
        }
    }

    /// <summary>
    /// 运算类工厂
    /// </summary>
    class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
                case "sqr":
                    oper = new OperationSqr();
                    break;
                case "sqrt":
                    oper = new OperationSqrt();
                    break;
                case "+/-":
                    oper = new OperationReverse();
                    break;
            }
            return oper;
        }
    }
}
