﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication
{
    class Program
    {
        #region Basic
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Hello World!");
        //    //Console.ReadLine();


        //var GetType()
        //    var someNumber = 0;

        //    Console.WriteLine(someNumber.GetType());

        //    return;
        //}
        #endregion

        #region Scope Demo
        //static int j = 10;

        //static void Main(string[] args)
        //{
        //    int j = 20;

        //    Console.WriteLine(j); // 20
        //    Console.WriteLine(Program.j); // 10

        //    //const
        //    const int num = 100;
        //    //num = 200; // error
        //    Console.WriteLine(num); // 100

        //}
        #endregion

        #region Enum Demo
        //static int Main(string[] args)
        //{
        //    WriteGreeting(TimeOfDayEnum.Morning);
        //    return 0;
        //}

        //static void WriteGreeting(TimeOfDayEnum timeOfDay)
        //{
        //    switch (timeOfDay)
        //    {
        //        case TimeOfDayEnum.Morning:
        //            Console.WriteLine("Good Morning!");
        //            break;
        //        case TimeOfDayEnum.Afternoon:
        //            Console.WriteLine("Good Afternoon!");
        //            break;
        //        case TimeOfDayEnum.Evening:
        //            Console.WriteLine("Good Evening!");
        //            break;
        //        default:
        //            Console.WriteLine("Hello");
        //            break;
        //    }


        //}

        #endregion

        //This is a singleline comment;
        /* This comment
           spans multiple lines. */

        //String Name = String.Empty;
        //int _Identifier = 0;
        //int \u005Identifier = 0;

        //字段应总是私有的, 但在某些情况下也可以把常量或字段设置为公有. 原因是如果把字段设为公有,就不利于以后扩展或修改类.



        #region Using
        /// <summary>
        /// Test for Using
        /// http://stackoverflow.com/questions/75401/uses-of-using-in-c-sharp
        /// The reason for the "using" statement is to ensure that the object is disposed 
        /// as soon as it goes out of scope, and it doesn't require explicit code to ensure that this happens.
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    //using
        //    //using (i)
        //    //{
        //    //    Console.WriteLine(i);
        //    //}

        //    //using (TestForUsing t = new TestForUsing())
        //    //{
        //    //    var result = t.SayHi();
        //    //    Console.WriteLine(result);
        //    //}

        //    //TestForUsing t = new TestForUsing();

        //    //Console.WriteLine(t.SayHi());

        //    using (System.IO.StreamReader reader = new System.IO.StreamReader(""))
        //    {
        //        //dosomething
        //    }

        //    //Unhandled Exception: System.ArgumentException: Empty path name is not legal.
        //    //   at System.IO.StreamReader..ctor(String path, Encoding encoding, Boolean detec
        //    //tEncodingFromByteOrderMarks, Int32 bufferSize, Boolean checkHost)
        //    //   at System.IO.StreamReader..ctor(String path)
        //    //   at ConsoleApplication.Program.Main(String[] args) in E:\git\CSharpLearning\CS
        //    //harpLearning\ConsoleApplication\Program.cs:line 115


        //    //to

        //    System.IO.StreamReader streamReader = new System.IO.StreamReader("");

        //    try
        //    {
        //        //steamReader  code
        //    }
        //    finally
        //    {
        //        if (streamReader != null)
        //        {
        //            ((IDisposable)streamReader).Dispose();
        //        }
        //    }


        //    using (var conn = new SqlConnection("connection string"))
        //    {
        //        conn.Open();
        //    }



        //}
        #endregion



        // The C# Language Specification
        static void Main(string[] args)
        {

            #region 隐式类型的局部变量
            // 隐式类型的局部变量
            // https://msdn.microsoft.com/zh-cn/library/ff926074.aspx
            //var var1 = "This is clearly a string.";
            //var num = 24;

            //// System.Int32
            //Console.WriteLine(num.GetType());
            //Console.ReadLine();
            #endregion

            //var syllable = "ha";
            //var laugh = "";
            //for (var i = 0; i < 10; i++)
            //{
            //    laugh += syllable;
            //    Console.WriteLine(laugh);
            //}


            //byte b = Byte.MaxValue;
            ////255
            //Console.WriteLine(b);

            //string i = string.Empty;

            //Console.WriteLine(i);


            #region 遍历枚举
            //// 遍历枚举
            //foreach(int mode in Enum.GetValues(typeof(System.IO.FileMode)))
            //{
            //    string name = Enum.GetName(typeof(System.IO.FileMode), mode);

            //    string value = mode.ToString();

            //    Console.WriteLine(name + "    " + value);

            //}

            //foreach(int day in Enum.GetValues(typeof(TimeOfDayEnum)))
            //{
            //    string name = Enum.GetName(typeof(TimeOfDayEnum), day);
            //    string value = day.ToString();
            //    Console.WriteLine(name + "   " + value);
            //}

            #endregion


            //MyClass mc = new MyClass();
            //MyClass mc2 = mc;

            //int[] nums = { 1, 2, 3, 4, 5, 6};

            //// Outputs: 6
            //Console.WriteLine(nums.Length);


            // System.Collections.Generic.List<T> 泛型
            List<string> strings = new List<string>();




        }



    }


    //public enum FileMode
    //{
    //    CreateNew = 1,
    //    Create = 2,
    //    Open = 3,
    //    OpenOrCreate = 4,
    //    Truncate = 5,
    //    Append = 6
    //}

    public class MyClass
    {
    }

    public interface IMyInterface
    {

    }


}
