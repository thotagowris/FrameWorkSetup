using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.PageObject;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrameWorkSetUp.DataDriven.Script
{
    [TestClass]
    public class TestCreateBug
    {
        private TestContext _testContext;

            public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"C:\Users\Gowri Thota\FrameWorkSetup\CreateData.csv", "CreateData#csv", DataAccessMethod.Sequential)]
        public void TestBug()
        {
            NavigationHelper.NavigateToUrl(ObjectRepositiry.config.GetWebsite());
            HomePage hpPage = new HomePage(ObjectRepositiry.Driver);
            LoginPage loginPage = hpPage.NavigateToLogin();
            var ePage = loginPage.Login(ObjectRepositiry.config.GetUsername(), ObjectRepositiry.config.GetPassword());
            //var bugPage = ePage.NavigateToDetail();
            ePage.SelectFromCombo(TestContext.DataRow["Severity"].ToString(), TestContext.DataRow["HardWare"].ToString(), TestContext.DataRow["OS"].ToString());
            ePage.TypeIn(TestContext.DataRow["Summary"].ToString(), TestContext.DataRow["Desc"].ToString());
            ePage.ClickSubmit();
            ePage.Logout();
            Thread.Sleep(5000);
        }
    }

}
