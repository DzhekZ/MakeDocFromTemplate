using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeDocFromTemplate.DB;

namespace MakeDocFromTemplate.Model
{
    public class DbData
    {
        public MakeDocDataSet.Библиотека_продуктовDataTable Products { get; set; }
        public MakeDocDataSet.Заказ_на_доставкуDataTable DeliveryOrder { get; set; }
        public MakeDocDataSet.МагазинDataTable Stores { get; set; }
        public MakeDocDataSet.Составляющие_заказаDataTable OrderDetails { get; set; }

        public Dictionary<string, System.Data.DataTable> TablesFromDb { get; set; }
        public DbData()
        {
            TablesFromDb = new Dictionary<string, System.Data.DataTable>();
        }
    }
}
