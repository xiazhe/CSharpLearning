using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

/// <summary>
/// Lambda 表达式
/// </summary>
namespace LambdaTest
{
    class Program
    {
        public delegate string mydelegate(string s);

        delegate int del(int i);

        delegate bool myDel(int x, int y);

        static void Main(string[] args)
        {
            #region demo 1
            //string mid = ", middle part";

            ////函数名 变量
            //Func<string, string> lambda = param =>
            // {
            //     param += mid;
            //     param += " and this was added to the string.";
            //     return param;
            // };

            //Console.WriteLine(lambda("Start to string"));
            #endregion


            // 格式：(形参列表) => { 函数体 }
            // 作用：简化匿名方法的书写,可用在任何可使用匿名方法和强类型代理的地方；

            #region demo 2
            //mydelegate d1;
            //d1 = delegate (string myarg)
            //{
            //    Console.WriteLine("anonymous method output: {0}", myarg); return "anonymous method done";
            //};
            //d1 += ((string myarg) =>
            //{
            //    Console.WriteLine("lamda expression output: {0}", myarg); return "lamda ok";
            //});

            //Console.WriteLine("d1 output: {0}", d1("arg"));

            // output :
            // anonymous method output: arg
            // lamda expression output: arg
            // d1 output: lamda ok
            #endregion


            // Lambda 表达式是一种可用于创建委托或表达式目录树类型的匿名函数
            // https://msdn.microsoft.com/zh-cn/library/bb397687.aspx

            #region demo 3
            // 表达式 lambda
            //del myDelegate = x => x * x;
            //int j = myDelegate(5); //j = 25
            //Console.WriteLine(j);
            #endregion

            //Expression<del> myEt = x => x * x;
            //Console.WriteLine(myEt);

            // 语句 lambda  (input parameters) => { statement; }
            myDel isSame = (x, y) => { return x == y; };

            myDel isSame2 = (int x, int y) => { return x == y; };

            Console.WriteLine(isSame2(10, 10)); // false







        }
    }
}
