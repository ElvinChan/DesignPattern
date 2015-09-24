using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department dept = new Department();

            IUser iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = DataAccess.CreateDepartment();
            id.Insert(dept);
            id.GetDepartment(1);

            Console.Read();
        }
    }

    /// <summary>
    /// User类
    /// </summary>
    class User
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    /// <summary>
    /// Department类
    /// </summary>
    class Department
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _deptName;

        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }
    }

    interface IUser
    {
        void Insert(User user);

        User GetUser(int id);
    }

    /// <summary>
    /// SqlServer操作User的类
    /// </summary>
    class SqlServerUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在SqlServer中给User表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在SqlServer中根据ID得到User表中的一条记录");
            return null;
        }
    }

    /// <summary>
    /// Access操作User的类
    /// </summary>
    class AccessUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Access中给User表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Access中根据ID得到User表中的一条记录");
            return null;
        }
    }

    interface IDepartment
    {
        void Insert(Department department);

        Department GetDepartment(int id);
    }

    /// <summary>
    /// SqlServer操作Department的类
    /// </summary>
    class SqlServerDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在SqlServer中给Department表增加一条记录");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SqlServer中根据ID得到Department表一条记录");
            return null;
        }
    }

    /// <summary>
    /// Access操作Department的类
    /// </summary>
    class AcessDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在Access中给Department表增加一条记录");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Access中根据ID得到Department表一条记录");
            return null;
        }
    }

    /// <summary>
    /// 操作数据的类
    /// </summary>
    class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactory";
        private static readonly string db = ConfigurationManager.AppSettings["DB"];
        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
