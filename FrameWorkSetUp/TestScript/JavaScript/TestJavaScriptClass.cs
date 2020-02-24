using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.JavaScript
{
    [TestClass]
    public class TestJavaScriptClass
    {
        [TestMethod]
        public void TestJavaScript()
        {
            NavigationHelper.NavigateToUrl("https://www.udemy.com/");
            //LinkHelper.ClickLink(By.LinkText("File a Bug"));
            IJavaScriptExecutor executor = ((IJavaScriptExecutor)ObjectRepository.Driver);
            //executor.ExecuteScript("document.getElementById('Bugzilla_login').value='thota.gowri@gmail.com'");
            //executor.ExecuteScript("document.getElementById('Bugzilla_password').value='chaithanya'");
            //executor.ExecuteScript("document.getElementById('log_in').click()");

            IWebElement element = ObjectRepository.Driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div[4]/div/div[2]/div[1]/div/div/a/div/div"));
            executor.ExecuteScript("window.scrollTo(0, " + element.Location.Y +")");
            element.Click();
        }
    }
}
