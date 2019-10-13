using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeDocFromTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            var func = new MainFunctions();

            func.StartApp();

            Console.Read();
        }
    }
}
