using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.BrowserActions
{
    [TestClass]
    public class TestBrowserActions
    {
        [TestMethod]
        public void TestActions()
        {
            NavigationHelper.NavigateToUrl(ObjectRepositiry.config.GetWebsite());
            //BrowserHelper.BrowserMaximize();
            //ObjectRepositiry.Driver.Manage().Window.Maximize();
            ButtonHelper.ClickButton(By.Id("enter_bug"));
            BrowserHelper.GoBack();
            //ObjectRepositiry.Driver.Navigate().Back();
            BrowserHelper.Forward();
            //ObjectRepositiry.Driver.Navigate().Forward();
            BrowserHelper.Refresh();
            //ObjectRepositiry.Driver.Navigate().Refresh();
        }
    }
}
