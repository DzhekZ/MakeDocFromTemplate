using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excel.Core.DataReader;
using MakeDocFromTemplate.Model;

namespace MakeDocFromTemplate
{
    public class ExcelFunctions
    {
        public ParamsForTemplate ReadDataForParamsForTemplate(string filePath)
        {
            Console.WriteLine($"Start load Excel file from {filePath}");

            ParamsForTemplate data = new ParamsForTemplate();

            if (!Path.IsPathRooted(filePath))
            {
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);
            }

            data.FileName = filePath;
            data.Date = DateTime.Now;

            ExcelReader excelReader = new ExcelReader(filePath);

            List<string> errorList;
            var rows = excelReader.ReadRows<ParamRow>(0, 3, out errorList);
            data.ImportErrors = errorList;
            data.Params = rows;

            Console.WriteLine($"End load Excel file from {filePath}. Errors: {data.GetErrorsString()}");

            return data;
        }
        public static ImportQuotasData ReadData(string filePath)
        {
            ImportQuotasData data = new ImportQuotasData();

            if (!Path.IsPathRooted(filePath))
            {
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);
            }

            data.FileName = filePath;

            ExcelReader excelReader = new ExcelReader(filePath);
            var titleCell = excelReader.ReadCell<string>(0, 0, 0);

            if (string.IsNullOrEmpty(titleCell))
            {
                throw new Exception("Не найдена строка с датой квот на грузопочтовые перевозки");
            }

            DateTime quotaDate;
            if (DateTime.TryParseExact(titleCell, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out quotaDate))
            {
                data.Date = quotaDate;
            }
            else
            {
                data.ImportErrors.Add("Не определена дата квоты на грузопочтовые перевозки");
                return data;
            }

            List<string> errorList;
            var rows = excelReader.ReadRows<QuotaRow>(0, 3, out errorList);
            data.ImportErrors = errorList;
            data.Quotas = rows;

            return data;
        }

    }
}
