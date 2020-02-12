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
    public class HomePage : PageBase
    {
        private IWebDriver driver;

        #region WebElement 

        [FindsBy(How = How.Id, Using = "quicksearch_main")]
        private IWebElement QuickSearcTextBox;

        [FindsBy(How = How.Id, Using = "find")]
        [CacheLookup]
        private IWebElement QuickSearchBtn;

        [FindsBy(How = How.LinkText, Using = "File a Bug")]
        private IWebElement FileABugLink;

        //private By QuickSearcTextBox = By.Id("quicksearch_main");
        //private By QuickSearchBtn = By.Id("find");
        //private By FileABugLink = By.LinkText("File a Bug");

        #endregion

            public HomePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Action

        public void QuickSearch(string text)
        {
            QuickSearcTextBox.SendKeys(text);
            QuickSearchBtn.Click();
        }

        #endregion

        #region Navigation

        public LoginPage NavigateToLogin()
        {
            FileABugLink.Click();
            return new LoginPage(driver);
        }

        #endregion
    }
}
