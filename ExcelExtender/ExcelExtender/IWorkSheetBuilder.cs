using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace WorkSheetExtender
{
    interface IWorkSheetBuilder
    {
        void SetHeaderColumns(Dictionary<string, string> headerColumns);
        void SetWorkSheetData<T>(IEnumerable<T> sourceData);
        ExcelWorksheet GetWorkSheet(); 
    }
}
