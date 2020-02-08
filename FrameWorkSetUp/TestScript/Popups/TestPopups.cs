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
            var text = JavaScriptPopHelper.GetPopUpText();
            JavaScriptPopHelper.ClickOnPopUp();
            //IAlert alert = ObjectRepositiry.Driver.SwitchTo().Alert();
            //var text = alert.Text;
            //alert.Accept();
            ObjectRepositiry.Driver.SwitchTo().DefaultContent();
            //TextBoxHelper.ClearTextBox(By.Id("textareaCode"));
            //TextBoxHelper.TypeInTextBox(By.Id("textareaCode"), text);
        }

        [TestMethod]
        public void TestConfirmPopup()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/tryit.asp?filename=tryjs_confirm");
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.CssSelector("body > button:nth-child(2)"));
            Thread.Sleep(2000);
            var text = JavaScriptPopHelper.GetPopUpText();
            JavaScriptPopHelper.ClickOnPopUp();
            Thread.Sleep(2000);
            //IAlert confirm = ObjectRepositiry.Driver.SwitchTo().Alert();
            //confirm.Accept();
            ButtonHelper.ClickButton(By.CssSelector("body > button:nth-child(2)"));
            Thread.Sleep(2000);
            var text2 = JavaScriptPopHelper.GetPopUpText();
            Thread.Sleep(2000);
            JavaScriptPopHelper.ClickCancelOnPopup();
            Thread.Sleep(2000);
            ObjectRepositiry.Driver.SwitchTo().DefaultContent();
            //IAlert reject = ObjectRepositiry.Driver.SwitchTo().Alert();
            //reject.Dismiss();
            //TextBoxHelper.ClearTextBox(By.CssSelector(".CodeMirror"));
            //TextBoxHelper.TypeInTextBox(By.CssSelector(".CodeMirror"), text);
        }

        [TestMethod]
        public void TestPrompt()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/tryit.asp?filename=tryjs_prompt");
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.CssSelector("body > button:nth-child(2)"));
            //IAlert prompt = ObjectRepositiry.Driver.SwitchTo().Alert();
            JavaScriptPopHelper.sendKeys("This is Automation");
            JavaScriptPopHelper.ClickOnPopUp();
            //prompt.SendKeys("This Is Automation");
            //prompt.Accept();
            Thread.Sleep(2000);
            
            ButtonHelper.ClickButton(By.CssSelector("body > button:nth-child(2)"));
            JavaScriptPopHelper.sendKeys("This is Automation");
            JavaScriptPopHelper.ClickCancelOnPopup();
            //prompt = ObjectRepositiry.Driver.SwitchTo().Alert();
            //prompt.Dismiss();
            Thread.Sleep(2000);
        }
    }
}
