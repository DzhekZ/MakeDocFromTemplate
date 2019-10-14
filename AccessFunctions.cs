using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MakeDocFromTemplate.DB;

namespace MakeDocFromTemplate
{
    public static class AccessFunctions
    {
        public static T LoadTable<T>(DbTables table)
        {
            switch (table)
            {
                case DbTables.Библиотека_продуктовDataTable:
                    var tblAdapter1 = new DB.MakeDocDataSetTableAdapters.Библиотека_продуктовTableAdapter();
                    var tblOut1 = tblAdapter1.GetData();
                    return (T)Convert.ChangeType(tblOut1,typeof(MakeDocDataSet.Библиотека_продуктовDataTable));
                    break;
                case DbTables.Заказ_на_доставкуDataTable:
                    var tblAdapter2 = new DB.MakeDocDataSetTableAdapters.Заказ_на_доставкуTableAdapter();
                    var tblOut2 = tblAdapter2.GetData();
                    return (T)Convert.ChangeType(tblOut2, typeof(MakeDocDataSet.Заказ_на_доставкуDataTable));
                    break;
                case DbTables.МагазинDataTable:
                    var tblAdapter3 = new DB.MakeDocDataSetTableAdapters.МагазинTableAdapter();
                    var tblOut3 = tblAdapter3.GetData();
                    return (T)Convert.ChangeType(tblOut3, typeof(MakeDocDataSet.МагазинDataTable));
                    break;
                case DbTables.Составляющие_заказаDataTable:
                    var tblAdapter4 = new DB.MakeDocDataSetTableAdapters.Составляющие_заказаTableAdapter();
                    var tblOut4 = tblAdapter4.GetData();
                    return (T)Convert.ChangeType(tblOut4, typeof(MakeDocDataSet.Составляющие_заказаDataTable));
                    break;
                default:
                    return (T)Convert.ChangeType(null, typeof(T));
                    break;
            }
        }

    }

    public enum DbTables
    {
        Библиотека_продуктовDataTable,
        Заказ_на_доставкуDataTable,
        МагазинDataTable,
        Составляющие_заказаDataTable
    }
}
