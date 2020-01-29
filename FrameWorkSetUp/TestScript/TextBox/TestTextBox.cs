using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepositiry.config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            //IWebElement ele = ObjectRepositiry.Driver.FindElement(By.Id("Bugzilla_login"));
            //ele.SendKeys(ObjectRepositiry.config.GetUsername());
            //ele = ObjectRepositiry.Driver.FindElement(By.Id("Bugzilla_password"));
            //ele.SendKeys(ObjectRepositiry.config.GetPassword());
            //ele = ObjectRepositiry.Driver.FindElement(By.Id("Bugzilla_login"));
            //ele.Clear();
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepositiry.config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepositiry.config.GetPassword());
            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));


        }

    }
}
