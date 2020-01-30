﻿using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.RadioButton
{
    [TestClass]
    public class HandleRadioButton
    {
        [TestMethod]
        public void TestRadio()
        {
            NavigationHelper.NavigateToUrl(ObjectRepositiry.config.GetWebsite());
            IWebElement element = ObjectRepositiry.Driver.FindElement(By.XPath("//a[@id='enter_bug']/span"));
            Console.WriteLine("Text : {0}", element.Text);
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepositiry.config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepositiry.config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            LinkHelper.ClickLink(By.XPath("/html/body/div[1]/ul[1]/li[9]/a"));
            LinkHelper.ClickLink(By.XPath(".//dt[@id='parameters']/a"));
            //IWebElement element = ObjectRepositiry.Driver.FindElement(By.Id("ssl_redirect-on"));
            //element.Click();
            Console.WriteLine("Selected : {0}", RadioButtonHelper.IsRadioButtonSelected(By.Id("ssl_redirect-off")));
            RadioButtonHelper.ClickRadioButton(By.Id("ssl_redirect-on"));

        }
    }
}
