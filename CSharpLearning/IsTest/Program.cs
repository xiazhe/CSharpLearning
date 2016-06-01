using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTest
{
    class Program
    {
        /// <summary>
        /// is
        /// https://msdn.microsoft.com/en-us/library/scekt9xw.aspx
        /// Checks if an object is compatible with a given type. 
        /// For example, the following code can determine if an object is an instance of the MyObject type, or a type that derives from MyObject:
        /// 检查对象是否与给定类型兼容。 例如，下面的代码可以确定对象是否为 MyObject 类型的一个实例，或者对象是否为从 MyObject 派生的一个类型
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            Class3 c3 = new Class3();
            Test(c1);
            Test(c2);
            Test(c3);
            Test("a string");
        }

        static void Test(object o)
        {
            Class1 a;
            Class2 b;

            if (o is Class1)
            {
                Console.WriteLine("o is Class1");
                a = (Class1)o;
            }
            else if (o is Class2)
            {
                Console.WriteLine("o is Class2");
                b = (Class2)o;
            }
            else
            {
                Console.WriteLine("o is neither Class1 nor Class2");
            }

        }

    }


    class Class1
    {

    }

    class Class2
    {

    }

    class Class3 : Class2
    {

    }

}
