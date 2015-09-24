using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }

        public void Wash()
        {
            Console.WriteLine("洗衣");
        }

        public void BuyRice()
        {
            Console.WriteLine("买米");
        }
    }

    //学雷锋的大学生
    class Undergraduate : LeiFeng
    { }

    //社区志愿者
    class Volunteer : LeiFeng
    { }

    #region 简单工厂
    //简单雷锋工厂
    class SimpleFactory
    {
        public static LeiFeng CreateLeiFeng(string type)
        {
            LeiFeng result = null;
            switch (type)
            {
                case "学雷锋的大学生":
                    result = new Undergraduate();
                    break;
                case "社区志愿者":
                    result = new Volunteer();
                    break;
                default:
                    break;
            }
            return result;
        }
    } 
    #endregion

    //雷锋工厂
    interface ILeiFengFactory
    {
        LeiFeng CreateLeiFeng();
    }

    //学雷锋的大学生工厂
    class UndergraduateFactory : ILeiFengFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }

    //社区志愿者工厂
    class VolunteerFactory : ILeiFengFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}
