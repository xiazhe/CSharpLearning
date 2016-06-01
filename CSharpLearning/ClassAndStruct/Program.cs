using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndStruct
{
    class Program
    {
        /// <summary>
        /// refrence
        /// C# 高级编程 3.1
        /// https://msdn.microsoft.com/zh-cn/library/ms173109.aspx
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PhoneCustomer phoneCustomer = new PhoneCustomer(); //work for a class

            PhoneCustomerStruct phoneCustomerStruct = new PhoneCustomerStruct(); // work for a struct

            Console.WriteLine(phoneCustomer.CustomID);

            phoneCustomer.FirstName = "Jimi";

            Console.WriteLine(phoneCustomer.FirstName);

        }

        void DoSomeThing(string log)
        {
            Console.WriteLine(log);
        }
    }
}
