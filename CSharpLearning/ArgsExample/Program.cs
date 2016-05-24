using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgsExample
{
    class Program
    {
        public static int Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)
            {
                Console.WriteLine(args[i]);
            }

            Console.ReadLine();

            return 0;
        }
    }
}
