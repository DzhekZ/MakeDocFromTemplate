using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel.Core;

namespace MakeDocFromTemplate.Model
{
    public class ParamRow
    {
        [ExcelImport("Значение в шаблоне", Order = 1)]
        public string ValueInTemplate { get; set; }

        [ExcelImport("Вид данных", Order = 2)]
        public string DataType { get; set; }

        [ExcelImport("Название таблицы", Order = 3)]
        public string TableName { get; set; }

        [ExcelImport("Поле", Order = 4)]
        public string CellName { get; set; }

        [ExcelImport("Формула", Order = 5)]
        public string Formula { get; set; }
    }
}
