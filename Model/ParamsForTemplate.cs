using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeDocFromTemplate.Model
{
    public class ParamsForTemplate
    {
        public ParamsForTemplate()
        {
            Params = new List<ParamRow>();
            ImportErrors = new List<string>();
        }

        public DateTime Date { get; set; }

        public IList<ParamRow> Params { get; set; }

        public string FileName { get; set; }

        public IList<string> ImportErrors { get; set; }


        public string GetErrorsString()
        {
            return ImportErrors.Count > 0 ? string.Join("\n", ImportErrors) : null;
        }

    }
}
