using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.ExcelReader
{
    public class ExcelReaderHelper
    {
        private static IDictionary<string, IExcelDataReader> _cathe;
        private static FileStream stream;
        private static IExcelDataReader reader;

        static ExcelReaderHelper()
        {
            _cathe = new Dictionary<string, IExcelDataReader>();
        }

        public static object GetCellData(string xlpath, string sheetName, int row, int column)
        {
            if (_cathe.ContainsKey(sheetName))
            {
                reader = _cathe[sheetName];
            }
            else
            {
                stream = new FileStream(xlpath, FileMode.Open, FileAccess.Read);
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                _cathe.Add(sheetName, reader);
            }

            DataTable table = reader.AsDataSet().Tables[sheetName];
            return GetData(table.Rows[row][column].GetType(), table.Rows[row][column]);
        }

        private static object GetData(Type type, Object data)
        {
            switch (type.Name)
            {
                case "String":
                    return data.ToString();
                case "Double":
                    return Convert.ToDouble(data);

                case "DateTime":
                    return Convert.ToDateTime(data);

                default:
                    return data.ToString();
            }
        }
    }
}
