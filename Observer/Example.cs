using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    //通知者接口
    interface ISubject
    {
        void Notify();
        string SubjectState
        {
            set;
            get;
        }
    }

    //事件处理程序的委托
    delegate void EventHandler();

    class Secretary : ISubject
    {
        //声明一事件Update，类型为委托EventHandler
        public event EventHandler Update;

        private string action;

        public void Notify()
        {
            Update();
        }

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }

    class Boss : ISubject
    {
        //声明一事件Update，类型为委托EventHandler
        public event EventHandler Update;

        private string action;

        public void Notify()
        {
            Update();
        }

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }

    //看股票的同事
    class StockObserver
    {
        private string name;
        private ISubject sub;
        public StockObserver(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        //关闭股票行情
        public void CloseStockMarket()
        {
            Console.WriteLine("{0} {1} 关闭股票行情，继续工作！",sub.SubjectState, name);
        }
    }

    //看NBA的同事
    class NBAOberver
    {
        private string name;
        private ISubject sub;
        public NBAOberver(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        //关闭NBA直播
        public void CloseNBADirectSeeding()
        {
            Console.WriteLine("{0} {1} 关闭NBA直播，继续工作！",sub.SubjectState, name);
        }
    }
}
