using FrameWorkSetUp.KeyWord;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.Keyword
{
    [TestClass]
    public class TestKeywordDriven
    {
        [TestMethod]
        public void TestKeyword()
        {
            DataEngine engine = new DataEngine();
            engine.ExecuteScript(@"C:\Development\Repos\FrameWorkSetUp\Keyword.xlsx", "TC01");
        }
    }
}
