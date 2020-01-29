using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.CheckBox
{
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]
        public void TestBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepositiry.config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepositiry.config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepositiry.config.GetPassword());
            //IWebElement element = ObjectRepositiry.Driver.FindElement(By.Id("Bugzilla_restrictlogin"));
            //element.Click();
            
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("Bugzilla_restrictlogin")));
            CheckBoxHelper.CheckedCheckBox(By.Id("Bugzilla_restrictlogin"));
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("Bugzilla_restrictlogin")));

        }
    }
}
