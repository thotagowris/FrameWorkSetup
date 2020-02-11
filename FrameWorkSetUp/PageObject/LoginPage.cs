using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.PageObject
{
    public class LoginPage
    {
        #region WebElement

        private By LoginTextBox = By.Id("Bugzilla_login");
        private By PassTextBox = By.Id("Bugzilla_password");
        private By LoginButton = By.Id("log_in");
        private By HomeLink = By.LinkText("Home");
        #endregion

        #region Action

        public void Login(string username, string password)
        {
            ObjectRepositiry.Driver.FindElement(LoginTextBox).SendKeys(username);
            ObjectRepositiry.Driver.FindElement(PassTextBox).SendKeys(password);
            ObjectRepositiry.Driver.FindElement(LoginButton).Click();

        }
        #endregion

        #region Navigation
        public void NavigateToHome()
        {
            ObjectRepositiry.Driver.FindElement(HomeLink).Click();
        }
        #endregion
    }
}
