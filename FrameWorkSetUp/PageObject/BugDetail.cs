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
        private IWebElement SeverityDropDown;

        [FindsBy(How = How.Id, Using = "rep_platform")]
        private IWebElement Hardware;

        [FindsBy(How = How.Id, Using = "op_sys")]
        private IWebElement OpSys;

        [FindsBy(How = How.Id, Using = "short_desc")]
        private IWebElement ShortDesc;

        [FindsBy(How = How.Id, Using = "comment")]
        private IWebElement Comment;

        [FindsBy(How = How.Id, Using = "commit")]
        private IWebElement Commit;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/ul[1]/li[2]/a")]
        private IWebElement NewBug;


        //Don't use the below code as this page no longer exists 
        //[FindsBy(How = How.LinkText, Using = "Testng")]
        //private IWebElement Testng;

        public BugDetail(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        //private By severityDropDown = By.Id("bug_severity");

        #endregion 


        #region Action


        public void SelectFromSeverity(string value)
        {
            ComboBoxHelper.SelectElement(SeverityDropDown, value);
            
        }

        public void SelectFromCombo(string severity = null, string hardware = null, string os = null)
        {
            if (severity != null)
                ComboBoxHelper.SelectElement(SeverityDropDown, severity);
            if (hardware != null)
                ComboBoxHelper.SelectElement(Hardware, hardware);
            if (os != null)
                ComboBoxHelper.SelectElement(OpSys, os);
        }

        public void TypeIn(string summary = null, string desc = null)
        {
            if (summary != null)
                ShortDesc.SendKeys(summary);
            if (desc != null)
                Comment.SendKeys(desc);
        }

        public void ClickSubmit()
        {
            Commit.Click();
            GenericHelper.WaitForWebElementInPage(By.Id("bugzilla-body"), TimeSpan.FromSeconds(30));
        }

        public new HomePage Logout()
        {
            base.Logout();
            return new HomePage(driver);
        }

        public void ClickOnNew()
        {
            NewBug.Click();
        }

        #endregion

       // #region Navigation

        //Don't use the below code as this page no longer exists

        //public BugDetail NavigateToDetail()
        //{
        //    Testng.Click();
        //    GenericHelper.WaitForWebElementInPage(By.Id("component"), TimeSpan.FromSeconds(30));
        //    return new BugDetail(driver);
        //}

        //#endregion
    }
}
