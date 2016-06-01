#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerprocessorDirectives
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("hello");
#endif

            Console.ReadLine();

        }
    }
}
