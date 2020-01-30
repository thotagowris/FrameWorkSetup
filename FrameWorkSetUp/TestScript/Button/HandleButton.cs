using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.Button
{
    [TestClass]
    public class HandleButton
    {
        [TestMethod]
        public void TestButton()
        {
            NavigationHelper.NavigateToUrl(ObjectRepositiry.config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepositiry.config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepositiry.config.GetPassword());
            //IWebElement element = ObjectRepositiry.Driver.FindElement(By.Id("log_in"));
            //element.Click();
            Console.WriteLine("Enabled : {0}", ButtonHelper.IsButtonEnabled(By.Id("log_in")));
            Console.WriteLine("Button Text : {0}", ButtonHelper.GetButtonText(By.Id("log_in")));
            ButtonHelper.ClickButton(By.Id("log_in"));
        }
    }
}
