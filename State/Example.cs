using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    //抽象状态
    public abstract class AbstractState
    {
        public abstract void WriteProgram(Work w);
    }

    //上午工作状态
    public class ForenoonState : AbstractState
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍",w.Hour);
            }
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }

    //中午工作状态
    public class NoonState : AbstractState
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine("当前时间：{0}点 饿了，午饭；犯困，午休。",w.Hour);
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }

    //下午工作状态
    public class AfternoonState : AbstractState
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力",w.Hour);
            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }

    //晚间工作状态
    public class EveningState : AbstractState
    {
        public override void WriteProgram(Work w)
        {
            if (w.Finish)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine("当前时间：{0}点 加班哦，疲累之极",w.Hour);
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }
        }
    }

    //睡眠状态
    public class SleepingState : AbstractState
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点 不行了，睡着了。", w.Hour);
        }
    }

    //下班休息状态
    public class RestState : AbstractState
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点 下班回家了", w.Hour);
        }
    }

    //工作
    public class Work
    {
        private AbstractState current;
        public Work()
        {
            current = new ForenoonState();
        }

        private double hour;

        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        private bool finish = false;

        public bool Finish
        {
            get { return finish; }
            set { finish = value; }
        }

        public void SetState(AbstractState s)
        {
            current = s;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}
