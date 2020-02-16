using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.ExcelReader
{
    [TestClass]
    public class TestExcelData
    {
        [TestMethod]
        public void TestReadExcel()
        {
            //FileStream stream = new FileStream(@"C:\Users\Gowri Thota\FrameWorkSetup\Data.xlsx", FileMode.Open, FileAccess.Read);
            //IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //DataTable table = reader.AsDataSet().Tables["Bugzilla"];
            //for (int i = 0; i< table.Rows.Count; i++)
            //{
            //    var col = table.Rows[i];
            //    for (int j = 0; j < col.ItemArray.Length; j++)
            //    {
            //        Console.Write("Data : {0}", col.ItemArray[j]);
            //    }
            //    Console.WriteLine();
            //}
            // Console.WriteLine("Data : {0}", table.Rows[0][0]);

            //string xlPath = @"C:\Users\Gowri Thota\FrameWorkSetup\Data.xlsx";
            string xlPath = @"C:\Users\Gowri Thota\FrameWorkSetup\Test.xlsx";
            Console.WriteLine(ExcelReaderHelper.GetCellData(xlPath, "Bugzilla", 0,0));
            Console.WriteLine(ExcelReaderHelper.GetCellData(xlPath, "Bugzilla", 0,1));
            Console.WriteLine(ExcelReaderHelper.GetCellData(xlPath, "Bugzilla", 0,2));
            //Console.WriteLine(ExcelReader.GetCellData(xlPath, "Codingbat", 3,0));
            //Console.WriteLine(ExcelReader.GetCellData(xlPath, "Codingbat", 3,1));
        }

       
    }
}
