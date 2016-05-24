using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// <summary>
/// Namespace Example 
/// 公司名.项目名.类名
/// </summary>


//namespace Teafish
//{
//    namespace ProCsharp
//    {
//        namespace Basics
//        {
//            class NamespaceExample
//            {
//                // Code for the class here.
//            }
//        }
//    }
//}

// 等同

namespace Teafish.ProCsharp.Basics
{
    public class NamespaceExample
    {
        public string GetNamespace()
        {
            return this.GetType().Namespace;
        } 
    }
}
