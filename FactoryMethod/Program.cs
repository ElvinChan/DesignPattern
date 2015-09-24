using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 计算器部分
            IFactory operFactory = new AddFactory();
            Operation oper = operFactory.CreateOperation();
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();

            Console.WriteLine(result); 
            #endregion

            #region 基本方式:薛磊风代表大学生学习雷锋
            LeiFeng xueleifeng = new Undergraduate();

            xueleifeng.BuyRice();
            xueleifeng.Sweep();
            xueleifeng.Wash();

            LeiFeng student1 = new Undergraduate();
            student1.BuyRice();
            LeiFeng student2 = new Undergraduate();
            student2.Sweep();
            LeiFeng student3 = new Undergraduate();
            student3.Wash(); 
            #endregion

            #region 简单工厂模式
            LeiFeng studentA = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            studentA.BuyRice();
            LeiFeng studentB = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            studentB.Sweep();
            LeiFeng studentC = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            studentC.Wash(); 
            #endregion

            #region 工厂方法模式
            ILeiFengFactory factory = new UndergraduateFactory();
            LeiFeng student = factory.CreateLeiFeng();

            student.BuyRice();
            student.Sweep();
            student.Wash();

            Console.Read(); 
            #endregion
        }
    }
}
