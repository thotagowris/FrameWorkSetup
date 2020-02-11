using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.PageObject
{
    public class HomePage
    {
        #region WebElement 

        private By QuickSearcTextBox = By.Id("quicksearch_main");
        private By QuickSearchBtn = By.Id("find");
        private By FileABugLink = By.LinkText("File a Bug");

        #endregion

        #region Action

        public void QuickSearch(string text)
        {
            ObjectRepositiry.Driver.FindElement(QuickSearcTextBox).SendKeys(text);
            ObjectRepositiry.Driver.FindElement(QuickSearchBtn).Click();
        }

        #endregion

        #region Navigation

        public void NavigateToLogin()
        {
            ObjectRepositiry.Driver.FindElement(FileABugLink).Click();
        }

        #endregion
    }
}
