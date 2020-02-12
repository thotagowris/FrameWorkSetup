using FrameWorkSetUp.BaseClasses;
using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.PageObject
{
    public class LoginPage : PageBase
    {
        private IWebDriver driver;
        #region WebElement

        [FindsBy(How = How.Id, Using ="Bugzilla_login") ]
        private IWebElement LoginTextBox;

        [FindsBy(How = How.Id, Using = "Bugzilla_password")]
        private IWebElement PassTextBox;

        [FindsBy(How = How.Id, Using = "log_in")]
        [CacheLookup]
        private IWebElement LoginButton;

        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink;

        //private By LoginTextBox = By.Id("Bugzilla_login");
        //private By PassTextBox = By.Id("Bugzilla_password");
        //private By LoginButton = By.Id("log_in");
        //private By HomeLink = By.LinkText("Home");
        #endregion

       public LoginPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }


        #region Action

        public BugDetail Login(string username, string password)
        {
            LoginTextBox.SendKeys(username);
            PassTextBox.SendKeys(password);
            LoginButton.Click();
            return new BugDetail(driver);

        }
        #endregion

        #region Navigation
        public void NavigateToHome()
        {
            HomeLink.Click();
        }
        #endregion
    }
}
