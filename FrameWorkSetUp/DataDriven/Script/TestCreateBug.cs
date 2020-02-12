using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.PageObject;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.DataDriven.Script
{
    [TestClass]
    class TestCreateBug
    {
        [TestMethod]
        public void TestBug()
        {
            NavigationHelper.NavigateToUrl(ObjectRepositiry.config.GetWebsite());
            HomePage hpPage = new HomePage(ObjectRepositiry.Driver);
            LoginPage loginPage = hpPage.NavigateToLogin();
            loginPage.Login(ObjectRepositiry.config.GetUsername(), ObjectRepositiry.config.GetPassword());
        }
    }

}
