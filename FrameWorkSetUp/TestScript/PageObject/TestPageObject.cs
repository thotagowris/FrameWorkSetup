﻿using FrameWorkSetUp.BaseClasses;
using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.PageObject;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.PageObject
{
    [TestClass]
    public class TestPageObject
    {
        [TestMethod]
        public void TestPage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepositiry.config.GetWebsite());
            HomePage homepage = new HomePage(ObjectRepositiry.Driver);
            LoginPage loginPage = homepage.NavigateToLogin();
            BugDetail bugDetail = loginPage.Login(ObjectRepositiry.config.GetUsername(), ObjectRepositiry.config.GetPassword());
            bugDetail.SelectFromSeverity("trivial");
            ButtonHelper.ClickButton(By.XPath("//*[@id='header']/ul[1]/li[10]/a"));

        }
    }
}
