using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.PageObject
{
    public class EnterBug
    {
        #region WebElement

        private By NewCaseLink = By.LinkText("New Case");

        #endregion

        #region Navigation
        public void NavigateToNewCasePage()
        {
            ObjectRepositiry.Driver.FindElement(NewCaseLink).Click();
        }
        #endregion
    }
}
