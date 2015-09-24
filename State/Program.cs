using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本用法（Basic.cs）
            Context c = new Context(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();
            #endregion

            #region 具体实例（Example.cs）
            //紧急项目
            Work emergencyProjects = new Work();
            emergencyProjects.Hour = 9;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 10;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 12;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 13;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 14;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 17;

            //emergencyProjects.WorkFinished = true;
            emergencyProjects.Finish = false;

            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 19;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 22;
            emergencyProjects.WriteProgram();
            
            Console.Read();
            #endregion
        }
    }
}
