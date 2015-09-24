using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Person
    {
        public Person()
        { }

        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", name);
        }
    }

    //服饰类
    class Finery : Person
    {
        protected Person component;

        //打扮
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }

    #region 各种服饰类
    class TShirt : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤");
            base.Show();
        }
    }

    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮裤");
            base.Show();
        }
    }

    class Sneaker : Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋");
            base.Show();
        }
    }

    class Suit : Finery
    {
        public override void Show()
        {
            Console.Write("西装");
            base.Show();
        }
    }

    class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("领带");
            base.Show();
        }
    }

    class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.Write("皮鞋");
            base.Show();
        }
    }
    #endregion
}
