﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    /// <summary>
    /// 运算类
    /// </summary>
    class Operation
    {
        private double _numberA = 0;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        private double _numberB = 0;

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
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
        }    }

    /// <summary>
    /// 除法类
    /// </summary>
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("除数不能为0。");
            result = NumberA / NumberB;
            return result;
        }
    }

    interface IFactory
    {
        Operation CreateOperation();
    }

    /// <summary>
    /// 专门负责生产“+”的工厂
    /// </summary>
    class AddFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }

    /// <summary>
    /// 专门负责生产“-”的工厂
    /// </summary>
    class SubFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }

    /// <summary>
    /// 专门负责生产“*”的工厂
    /// </summary>
    class MulFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }

    /// <summary>
    /// 专门负责生产“/”的工厂
    /// </summary>
    class DivFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
    }
}
