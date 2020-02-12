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
            if (GenericHelper.IsElelementPresent(By.XPath("//*[@id='header']/ul[1]/li[10]/a")))
            {
                ButtonHelper.ClickButton(By.XPath("//*[@id='header']/ul[1]/li[10]/a"));
            }
        }

        protected void NavigateToHomePage()
        {
            HomeLink.Click();
        }


    }
}
