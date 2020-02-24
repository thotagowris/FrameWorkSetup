using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.HyperLink
{
    [TestClass]
    public class TestHyperLink
    {
        [TestMethod]
        public void ClickLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //IWebElement element = ObjectRepositiry.Driver.FindElement(By.LinkText("File a Bug"));
            //element.Click();

            //IWebElement pelement = ObjectRepositiry.Driver.FindElement(By.PartialLinkText("File"));
            //pelement.Click();
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            LinkHelper.ClickLink(By.PartialLinkText("File"));
        }
    }
}
