using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MakeDocFromTemplate.Model;

namespace MakeDocFromTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            DbData data;
            var funcs = new MainFunctions();
            funcs.StartApp();
            funcs.LoadDataFromDbToMemory(out data);

            var excel = new ExcelFunctions();
            string excelFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ExcelFiles\\конфигурация для шаблона.xlsx";
            var fileTemplateParams = excel.ReadDataForParamsForTemplate(excelFileName);

            Console.Read();
        }
    }
}
