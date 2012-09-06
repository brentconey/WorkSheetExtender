using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSheetExtender;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("dbName", "Actual Header");
            test.Add("testName", "Another Header");
            WorkSheetBuilder worksheet = new WorkSheetBuilder();
            worksheet.SetHeaderColumns(test);
        }
    }
}
