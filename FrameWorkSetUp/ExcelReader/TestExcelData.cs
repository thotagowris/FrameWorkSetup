using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
            FileStream stream = new FileStream(@"C:\Users\Gowri Thota\FrameWorkSetup\Data.xlsx", FileMode.Open, FileAccess.Read);
        }
    }
}
