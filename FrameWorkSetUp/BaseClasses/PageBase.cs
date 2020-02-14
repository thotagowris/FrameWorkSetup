using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.BaseClasses
{
    public class PageBase
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using ="Home")]
        private IWebElement HomeLink;

        public PageBase(IWebDriver driver)
        {
            PageFactory.InitElements(ObjectRepositiry.Driver, this);
        }

        protected void Logout()
        {
            if (GenericHelper.IsElelementPresent(By.CssSelector("ul.links:nth-child(4) > li:nth-child(11) > a:nth-child(2)")))
            {
                ButtonHelper.ClickButton(By.CssSelector("ul.links:nth-child(4) > li:nth-child(11) > a:nth-child(2)"));
            }
        }

        protected void NavigateToHomePage()
        {
            HomeLink.Click();
        }


    }
}
