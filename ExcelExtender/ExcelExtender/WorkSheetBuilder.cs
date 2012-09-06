using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace WorkSheetExtender
{
    public class WorkSheetBuilder : IWorkSheetBuilder
    {
        public void SetHeaderColumns(Dictionary<string, string> headerColumns)
        {
            foreach (var pair in headerColumns)
            {
                var key = pair.Key;
                var value = pair.Value;
            }
        }

        public void SetWorkSheetData<T>(IEnumerable<T> sourceData)
        {
            throw new NotImplementedException();
        }

        public ExcelWorksheet GetWorkSheet()
        {
            throw new NotImplementedException();
        }
    }
}
