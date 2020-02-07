using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.Popups
{
    [TestClass]
    public class TestPopups
    {
        [TestMethod]
        public void TestAlert()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/js_popup.asp");
            ButtonHelper.ClickButton(By.XPath("//*[@id='main']/div[4]/a"));
            Thread.Sleep(2000);
            BrowserHelper.SwitchToWindow(1);
            Thread.Sleep(2000);
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.CssSelector("body > button:nth-child(2)"));
            IAlert alert = ObjectRepositiry.Driver.SwitchTo().Alert();
            var text = alert.Text;
            alert.Accept();
            ObjectRepositiry.Driver.SwitchTo().DefaultContent();
            //TextBoxHelper.ClearTextBox(By.Id("textareaCode"));
            //TextBoxHelper.TypeInTextBox(By.Id("textareaCode"), text);
        }
    }
}
