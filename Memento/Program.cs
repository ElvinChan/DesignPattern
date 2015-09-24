using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本用法（Basic.cs）
            Originator o = new Originator();
            //Originator初始状态，状态属性为“On”
            o.State = "On";
            o.Show();

            Caretaker c = new Caretaker();
            //保存状态时，由于有了很好的封装，可以隐藏Originator的实现细节
            c.Memento = o.CreateMemento();

            //Originator改变了状态属性为“Off”
            o.State = "Off";
            o.Show();

            //恢复原初始状态
            o.SetMemento(c.Memento);
            o.Show(); 
            #endregion

            #region 具体实例（Example.cs）
            //大战Boss前
            GameRole lixiaoyao = new GameRole();
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            //保存进度
            RoleStateCaretaker stateAdmin = new RoleStateCaretaker();
            stateAdmin.Memento = lixiaoyao.SaveState();

            //大战Boss时，损耗严重
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            //恢复之前的状态
            lixiaoyao.RecoveryState(stateAdmin.Memento);
            lixiaoyao.StateDisplay();

            Console.Read(); 
            #endregion
        }
    }
}
