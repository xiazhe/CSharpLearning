using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataSetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet[] dataSet = null;
            DataSet dt = new DataSet();


            Console.WriteLine(dataSet[0].IsInitialized);


        }



        /// <summary>
        /// 返回 DataSet 对象的 DataTableCollection，并打印每个表中的列和行。
        /// https://msdn.microsoft.com/zh-cn/library/system.data.dataset.tables(v=vs.110).aspx
        /// </summary>
        /// <param name="dataSet"></param>
        private void PrintRows(DataSet dataSet)
        {
            // For each table in the DataSet, print the row values.
            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        Console.WriteLine(row[column]);
                    }
                }
            }
        }
    }
}
