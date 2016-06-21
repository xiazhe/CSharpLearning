using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambdaAndEvent
{
    class Program
    {
        delegate double DoubleOp(double x);

        static void Main(string[] args)
        {
            #region Demo 1
            // 委托 Demo, 将变量x的ToString方法作为参数传给GetAString委托, 实例化一个新的firstStringMethod变量. 输出结果.
            //int x = 40;

            // 委托实例
            //GetAString firstStringMethod = new GetAString(x.ToString);
            //GetAString firstStringMethod = x.ToString;
            //var firstStringMethod = x.ToString(); //error 类型安全

            //方法的地址 x.ToString
            // Invoke 调用, firstStringMethod() 等同于 firstStringMethod.Invoke()
            //Console.WriteLine("String is {0}", firstStringMethod());
            //Console.WriteLine("String is {0}", firstStringMethod.Invoke());
            //Console.WriteLine("String is {0}", new GetAString(x.ToString)());

            //Currency balance = new Currency(34, 50);
            //firstStringMethod = balance.ToString;
            //Console.WriteLine("String is {0}", firstStringMethod());

            //firstStringMethod = new GetAString(Currency.getCurrencyUnit);
            //Console.WriteLine("String is {0}", firstStringMethod());
            #endregion

            #region Demo 2
            //相关: MathOperations 类

            //Console.WriteLine(MathOperations.MultiplyByTwo(2.0));
            //Console.WriteLine(MathOperations.MultiplyByTwo(7.94));
            //Console.WriteLine(MathOperations.MultiplyByTwo(1.414));

            //Console.WriteLine(MathOperations.Square(2.0));
            //Console.WriteLine(MathOperations.Square(7.94));
            //Console.WriteLine(MathOperations.Square(1.414));

            //委托数组
            //DoubleOp[] operations =
            //{
            //    MathOperations.MultiplyByTwo,
            //    MathOperations.Square
            //};


            //泛型
            //Func<double, double>[] operations =
            //{
            //    MathOperations.MultiplyByTwo,
            //    MathOperations.Square
            //};

            //for (int i = 0; i < operations.Length; i++)
            //{
            //    Console.WriteLine("Using operations[{0}]", i);
            //    ProcessAndDisplayNumber(operations[i], 2.0);
            //    ProcessAndDisplayNumber(operations[i], 7.94);
            //    ProcessAndDisplayNumber(operations[i], 1.414);
            //    Console.WriteLine();
            //}

            // Output:
            // Using operations[0]
            // Value is 2, result of operation is 4
            // Value is 7.94, result of operation is 15.88
            // Value is 1.414, result of operation is 2.828

            // Using operations[1]
            // Value is 2, result of operation is 4
            // Value is 7.94, result of operation is 63.0436
            // Value is 1.414, result of operation is 1.999396



            #endregion


            // 冒泡排序
            int[] sortArray = new int[5] { 0, 5, 6, 3, 2 };

            bool swapped = true;
            do
            {
                swapped = false;
                for(int i = 0; i < sortArray.Length -1; i++)
                {
                    if(sortArray[i] < sortArray[i+1])
                    {
                        int temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            for(int i = 0; i < sortArray.Length; i++)
            {
                Console.WriteLine(sortArray[i]);
            }






        }

        private static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
            double result = action(value);
            Console.WriteLine("Value is {0}, result of operation is {1}", value, result);
        }


        static void ProcessAndDisplayNumber(Func<double, double>action, double value)
        {
            double result = action(value);
            Console.WriteLine(
                "Value is {0}, result of operation is {1}", value, result);
        }

        delegate void IntMethodInvoker(int x);

        delegate double TwoLongsOp(long first, long second);

        private delegate string GetAString();



    }



    #region Currency
    struct Currency
    {
        public uint Dollars;
        public ushort Cents;

        /// <summary>
        /// 货币
        /// </summary>
        /// <param name="dollars">元</param>
        /// <param name="cents">分</param>
        public Currency(uint dollars, ushort cents)
        {
            this.Dollars = dollars;
            this.Cents = cents;
        }

        public override string ToString()
        {
            return string.Format("${0}.{1,2:00}", Dollars, Cents);
        }

        //获取单位
        public static string getCurrencyUnit()
        {
            return "Dollar";
        }

        public static explicit operator Currency(float value)
        {
            checked
            {
                uint dollars = (uint)value;
                ushort cents = (ushort)((value - dollars) * 100);
                return new Currency(dollars, cents);
            }
        }

        // implicit 关键字用于声明隐式的用户定义类型转换运算符。 
        // 如果可以确保转换过程不会造成数据丢失，则可使用该关键字在用户定义类型和其他类型之间进行隐式转换。
        // https://msdn.microsoft.com/zh-cn/library/z5z9kes2.aspx

        // 使用 operator 关键字来重载内置运算符，或提供类或结构声明中的用户定义转换。
        public static implicit operator float(Currency value)
        {
            return value.Dollars + (value.Cents / 100.0f);
        }

        public static implicit operator Currency(uint value)
        {
            return new Currency(value, 0);
        }

        public static implicit operator uint(Currency value)
        {
            return value.Dollars;
        }

        #endregion

    }



}
