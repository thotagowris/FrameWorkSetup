﻿using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.PageObject
{
    public class LoginPageGeneric
    {
        #region WebElement

        private By LoginTextBox = By.Id("Bugzilla_login");
        private By PassTextBox = By.Id("Bugzilla_password");
        private By LoginButton = By.Id("log_in");
        private By HomeLink = By.LinkText("Home");
        private IWebDriver driver;
        #endregion

        #region Action

        public BugDetail Login(string username, string password)
        {
            ObjectRepository.Driver.FindElement(LoginTextBox).SendKeys(username);
            ObjectRepository.Driver.FindElement(PassTextBox).SendKeys(password);
            ObjectRepository.Driver.FindElement(LoginButton).Click();
            return new BugDetail(driver);

        }
        #endregion

        #region Navigation
        public void NavigateToHome()
        {
            ObjectRepository.Driver.FindElement(HomeLink).Click();
        }
        #endregion
    }
}
