using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 2, 1, 0, 3 };

            int[] index = new int[] { 2, 0, 3, 2, 4, 0, 1, 3, 2, 3, 3 };
            string tel = "";
            for(int i = 0; i< index.Length; i++)
            {
                tel += arr[index[i]];
            }

            Console.WriteLine(tel);

        }
    }
}
