using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Context
    {
        private State state;

        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                Console.WriteLine("当前状态："+ state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }

    //抽象状态
    abstract class State
    {
        public abstract void Handle(Context context);
    }

    //具体状态
    class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
    
    //具体状态
    class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
