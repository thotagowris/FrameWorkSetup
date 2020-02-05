using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace FrameWorkSetUp.TestScript.WebDriverWaits
{
    [TestClass]
    public class TestWebDriverWait
    {
        [TestMethod]
        public void TestWait()
        {
            //NavigationHelper.NavigateToUrl("https://www.udemy.com/courses/");
            //TextBoxHelper.TypeInTextBox(By.Id("header-search-field"), "c#");

        }

        [TestMethod]
        public void TestDynamicWait()
        {
            NavigationHelper.NavigateToUrl("https://www.udemy.com/courses/");
            ObjectRepositiry.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            WebDriverWait wait = new WebDriverWait(ObjectRepositiry.Driver, TimeSpan.FromSeconds(50));
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            //Console.WriteLine(wait.Until(WaitforTitile()));
            wait.Until(WaitforElement()).SendKeys("health");
            ButtonHelper.ClickButton(By.CssSelector("span.input-group:nth-child(4) > span:nth-child(2) > button:nth-child(1)"));
            //wait.Until(WaitForButtonElement()).Click();
            wait.Until(WaitToSelectFromList()).Click();
            Console.WriteLine("Title : {0}", wait.Until(WaitForTitle()));
        }

        [TestMethod]
        public void TestExpCondition()
        {
            NavigationHelper.NavigateToUrl("https://www.udemy.com/courses/");
            ObjectRepositiry.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            WebDriverWait wait = new WebDriverWait(ObjectRepositiry.Driver, TimeSpan.FromSeconds(50));
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            wait.Until(ExpectedConditions.ElementExists(By.Id("search-field-home"))).SendKeys("HTML");
            ButtonHelper.ClickButton(By.CssSelector("span.input-group:nth-child(4) > span:nth-child(2) > button:nth-child(1)"));
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div.course-card-list--course-card-wrapper---5ot2:nth-child(22) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1)"))).Click();
            Console.WriteLine("Title : {0}", wait.Until(ExpectedConditions.TitleContains("u")));
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div.dropdown:nth-child(6) > div:nth-child(1) > button:nth-child(1)"))).Click();
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".loginbox-v4__content")));

        }

        private Func<IWebDriver, bool> waitforSearchbox()
        {
            return ((x) =>
            {
                Console.WriteLine("waiting for search box");
                return x.FindElements(By.Id("search-field-home")).Count == 1;
            });
        }

        private Func<IWebDriver, string> WaitforTitile()
        {
            return ((x) =>
             {
                 if (x.Title.Contains("Main"))
                 {
                     return x.Title;
                 }
                 else
                 {
                     return null;
                 }
             });
        }

        private Func<IWebDriver, IWebElement> WaitforElement()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for element");
                if (x.FindElements(By.Id("search-field-home")).Count ==1)
                
                    return x.FindElement(By.Id("search-field-home"));
                
                    return null;
                
            });
        }

        //private Func<IWebDriver, IWebElement> WaitForButtonElement()
        //{
        //    return ((x) =>
        //    {
        //        if (x.FindElements(By.XPath("//*[@id='udemy']/div[2]/div[3]/div[1]/div/div/div[3]/div/form/span/span/button/span")).Count == 1);

        //            return x.FindElement(By.XPath("//*[@id='udemy']/div[2]/div[3]/div[1]/div/div/div[3]/div/form/span/span/button/span"));
                
        //        return null;

        //    });
        //}

        private Func<IWebDriver, IWebElement> WaitToSelectFromList()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for List To Display");
                if (x.FindElements(By.CssSelector("div.course-card-list--course-card-wrapper---5ot2:nth-child(23) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > h4:nth-child(1)")).Count == 1) ;
                    return x.FindElement(By.CssSelector("div.course-card-list--course-card-wrapper---5ot2:nth-child(23) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > h4:nth-child(1)"));
                return null;
            });
        }

        private Func<IWebDriver, string> WaitForTitle()
        {
            return ((x) => 
            {
                Console.WriteLine("Waiting for Title to display");
                if (x.FindElement(By.CssSelector("h1.clp-lead__title")).Text.Contains("Certified Electronic Health Records Specialist")) ;
                {
                    return x.FindElement(By.CssSelector("h1.clp-lead__title")).Text;
                }
                return null;
            });
        }
    }
}
