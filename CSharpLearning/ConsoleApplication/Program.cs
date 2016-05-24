using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static int Main(string[] args)
        {
            WriteGreeting(TimeOfDayEnum.Morning);
            return 0;
        }

        static void WriteGreeting(TimeOfDayEnum timeOfDay)
        {
            switch (timeOfDay)
            {
                case TimeOfDayEnum.Morning:
                    Console.WriteLine("Good Morning!");
                    break;
                case TimeOfDayEnum.Afternoon:
                    Console.WriteLine("Good Afternoon!");
                    break;
                case TimeOfDayEnum.Evening:
                    Console.WriteLine("Good Evening!");
                    break;
                default:
                    Console.WriteLine("Hello");
                    break;
            }


        }

        #endregion

        //This is a singleline comment;
        /* This comment
           spans multiple lines. */





    }
}
