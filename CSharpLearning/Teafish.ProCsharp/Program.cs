using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Introduction = Teafish.ProCsharp.Basics;
using Teafish.ProCsharp.OOP;

namespace Teafish.ProCsharp
{
    class Test
    {
        public static int Main(string[] args)
        {
            //Basics.NamespaceExample nsEx = new Basics.NamespaceExample();

            //命名空间别名 namespace alias
            //Introduction.NamespaceExample nsEx = new Introduction.NamespaceExample();
            Introduction::NamespaceExample nsEx = new Introduction::NamespaceExample();

            Console.WriteLine(nsEx.GetNamespace());  // Teafish.ProCsharp.Basics
            return 0;

        }
    }
}
