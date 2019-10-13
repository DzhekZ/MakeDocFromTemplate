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

            var tblAdapter1 = new DB.MakeDocDataSetTableAdapters.МагазинTableAdapter();
            var tbl1 = tblAdapter1.GetData();
            Console.WriteLine($"Table {tbl1.TableName} has records - {tbl1.Count}");
        }
    }
}
