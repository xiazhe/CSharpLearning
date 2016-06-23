using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Demo 1
            //// Query #1.
            //List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //// The query variable can also be implicitly typed by using var
            //IEnumerable<int> filteringQuery =
            //    from num in numbers
            //    where num < 3 || num > 7
            //    select num;

            //// Query #2.
            //IEnumerable<int> orderingQuery =
            //    from num in numbers
            //    where num < 3 || num > 7
            //    orderby num ascending
            //    select num;

            //// Query #3.
            //string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
            //IEnumerable<IGrouping<char, string>> queryFoodGroups =
            //    from item in groupingQuery
            //    group item by item[0];

            //Console.WriteLine(string.Join(", ", filteringQuery.ToArray()));
            //// output: 1, 9, 8, 2, 0
            ////PrintEnum(filteringQuery);

            ////var _values = _tbl.AsEnumerable().Select(x => x);

            //Console.WriteLine(string.Join(", ", numbers.AsEnumerable().Select(x => x).ToArray()));
            #endregion

            #region demo 2
            List<int> numbers1 = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            List<int> numbers2 = new List<int>() { 15, 14, 11, 13, 19, 18, 16, 17, 12, 10 };

            // Query #4. average 计算序列的平均值 Decimal 值。
            double average = numbers1.Average();

            // Query #5. 合并
            IEnumerable<int> concatenationQuery = numbers1.Concat(numbers2);

            Console.WriteLine("Numbers1's average: {0}, Numbers2's concat: {1}", average, string.Join(", ", concatenationQuery.ToArray()));

            // output: 
            // Numbers1's average: 4.5, Numbers2's concat: 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 15, 14
            // , 11, 13, 19, 18, 16, 17, 12, 10

            // Query #6.
            IEnumerable<int> largeNumbersQuery = numbers2.Where(c => c > 15);

            Console.WriteLine(ConvertEnumToString(largeNumbersQuery));

            #endregion






        }

        static void PrintEnum(IEnumerable<int> Enum)
        {
            foreach (int i in Enum)
            {
                Console.WriteLine(i);
            }

        }


        static string ConvertEnumToString(IEnumerable<int> Enum)
        {
            return string.Join(", ", Enum);
        }

    }
}
