using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.PageObject
{
    public class HomePageGeneric
    {
        #region WebElement 

        private By QuickSearcTextBox = By.Id("quicksearch_main");
        private By QuickSearchBtn = By.Id("find");
        private By FileABugLink = By.LinkText("File a Bug");
        private IWebDriver driver;

        #endregion

        #region Action

        public void QuickSearch(string text)
        {
            ObjectRepositiry.Driver.FindElement(QuickSearcTextBox).SendKeys(text);
            ObjectRepositiry.Driver.FindElement(QuickSearchBtn).Click();
        }

        #endregion

        #region Navigation

        public LoginPage NavigateToLogin()
        {
            ObjectRepositiry.Driver.FindElement(FileABugLink).Click();
            return new LoginPage(driver);
        }

        #endregion
    }
}
