using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    /// <summary>
    /// 使用struct 自定义值类型
    /// </summary>
    public struct CoOrds
    {
        public int x, y;

        public CoOrds(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
}
