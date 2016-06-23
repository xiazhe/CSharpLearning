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
            //DataSet[] dataSet = null;
            //DataSet dt = new DataSet();

            //Console.WriteLine(dt.IsInitialized);

            DataSet customerOrders = new DataSet("CustomerOrders");

            DataTable ordersTable = customerOrders.Tables.Add("Orders");

            //主键列
            DataColumn pkOrderID = ordersTable.Columns.Add("OrderID", typeof(Int32));
            ordersTable.Columns.Add("OrderQuantity", typeof(Int32));
            ordersTable.Columns.Add("CompanyName", typeof(string));

            ordersTable.PrimaryKey = new DataColumn[] { pkOrderID };


            //添加数据
            ordersTable.Rows.Add(1, 0, "Microsoft");
            ordersTable.Rows.Add(2, 10, "Google Inc.");
            ordersTable.Rows.Add(3, 100, "Tea.Fish");

            PrintRows(customerOrders);
            


            Console.WriteLine();





        }



        /// <summary>
        /// 返回 DataSet 对象的 DataTableCollection，并打印每个表中的列和行。
        /// https://msdn.microsoft.com/zh-cn/library/system.data.dataset.tables(v=vs.110).aspx
        /// </summary>
        /// <param name="dataSet"></param>
        private static void PrintRows(DataSet dataSet)
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
