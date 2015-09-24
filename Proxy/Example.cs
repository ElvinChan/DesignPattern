using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    interface GiveGift
    {
        void GiveDolls();
        void GiveFlowers();
        void GiveChocolate();
    }

    class PursuitProxy : GiveGift
    {
        Pursuit gg;
        public PursuitProxy(SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }

    class Pursuit : GiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + "送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + "送你鲜花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + "送你巧克力");
        }
    }

    class SchoolGirl
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
