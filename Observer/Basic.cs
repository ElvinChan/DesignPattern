using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    //抽象通知者
    abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

        //增加观察者
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        //移除观察者
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        //通知
        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }
    }

    //具体通知者
    class ConcreteSubject : Subject
    {
        private string subjectState;

        //具体通知者状态
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }

    //抽象观察者
    abstract class Observer
	{
		public abstract void Update();
	}

    //具体观察者
    class ConcreteObserver : Observer
	{
        private string name;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        //更新
        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("观察者{0}的新状态是{1}",name,observerState);
        }

        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
	}
}
