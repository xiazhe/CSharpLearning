using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 构造函数代码练习
/// https://msdn.microsoft.com/zh-cn/library/k6sa6h87.aspx
/// https://msdn.microsoft.com/zh-cn/library/ms173115.aspx
/// </summary>
namespace ConstructorTest
{
    public class Taxi
    {
        public bool isInitialized;
        public Taxi()
        {
            isInitialized = true;
        }
    }

    /// <summary>
    /// 静态类
    /// </summary>
    public static class staticClass
    {
        //public bool isInitialized;
        //public staticClass()
        //{
        //    isInitialized = true;
        //}

        //error 静态类不能有构造函数

    }

    /// <summary>
    /// 多个构造函数的类
    /// </summary>
    public class Employee
    {
        public int salary;

        public Employee(int annualSalary)
        {
            salary = annualSalary;
        }

        public Employee(int weeklySalary, int numberOfWeeks)
        {
            salary = weeklySalary * numberOfWeeks;
        }
    }

    /// <summary>
    /// 构造函数可以使用 base 关键字来调用基类的构造函数
    /// </summary>
    public class Manager: Employee
    {
        public int salary;
        public Manager(int annualSalary)
            : base(annualSalary)
        {
            salary = base.salary;

            //Add further instructions here.
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Taxi t = new Taxi();
            Console.WriteLine(t.isInitialized);

            int i = new int();
            Console.WriteLine(i);
            //output: 0

            Employee e1 = new Employee(30000);
            Employee e2 = new Employee(500, 52);
            Console.WriteLine("e1.salary: {0}, e2.salary: {1}", e1.salary, e2.salary);
            //output: e1.salary: 30000, e2.salary: 26000

            Manager m1 = new Manager(5000);
            Console.WriteLine("Manager's salary: {0}", m1.salary);

        }
    }

    class NLog
    {
        // Private Constructor:
        private NLog()
        {

        }

        public static double e = Math.E;
    }


}
