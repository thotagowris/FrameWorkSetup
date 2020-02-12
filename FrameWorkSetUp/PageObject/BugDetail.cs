using FrameWorkSetUp.BaseClasses;
using FrameWorkSetUp.ComponentHelper;
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
    public class BugDetail : PageBase
    {
        private IWebDriver driver;
        #region WebElement

        [FindsBy(How = How.Id, Using = "bug_severity")]
        private IWebElement severityDropDown;

        public BugDetail(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        //private By severityDropDown = By.Id("bug_severity");

        #endregion


        #region Action


        public void SelectFromSeverity(string value)
        {
            ComboBoxHelper.SelectElement(severityDropDown, value);
            
        }
        #endregion
    }
}
