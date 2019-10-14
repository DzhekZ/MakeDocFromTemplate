using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeDocFromTemplate
{
    public class MainFunctions
    {
        public MainFunctions()
        {
            //constructor
        }

        public void StartApp()
        {
            Console.WriteLine($"Application started at {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}");
            using (DB.MakeDocDataSet db = new DB.MakeDocDataSet())
            {
                Console.WriteLine($"Tables count - {db.Tables.Count}");
            }

            var tbl1 = AccessFunctions.LoadTable<DB.MakeDocDataSet.Библиотека_продуктовDataTable>(DbTables.Библиотека_продуктовDataTable);
            Console.WriteLine($"Table {tbl1.TableName} has records - {tbl1.Count}");
            var tbl2 = AccessFunctions.LoadTable<DB.MakeDocDataSet.Заказ_на_доставкуDataTable>(DbTables.Заказ_на_доставкуDataTable);
            Console.WriteLine($"Table {tbl2.TableName} has records - {tbl2.Count}");
            var tbl3 = AccessFunctions.LoadTable<DB.MakeDocDataSet.МагазинDataTable>(DbTables.МагазинDataTable);
            Console.WriteLine($"Table {tbl3.TableName} has records - {tbl3.Count}");
            var tbl4 = AccessFunctions.LoadTable<DB.MakeDocDataSet.Составляющие_заказаDataTable>(DbTables.Составляющие_заказаDataTable);
            Console.WriteLine($"Table {tbl4.TableName} has records - {tbl4.Count}");
        }

    }
}
