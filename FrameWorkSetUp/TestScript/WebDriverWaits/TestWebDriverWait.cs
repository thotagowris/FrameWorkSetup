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
            //NavigationHelper.NavigateToUrl("https://www.udemy.com/courses/");
            //ObjectRepositiry.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            //WebDriverWait wait = new WebDriverWait(ObjectRepositiry.Driver, TimeSpan.FromSeconds(50));
            //wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            ////Console.WriteLine(wait.Until(WaitforTitile()));
            //wait.Until(WaitforElement()).SendKeys("health");
            //wait.Until(WaitForButtonElement()).Click();
            //wait.Until(WaitToSelectFromList()).Click();
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

        private Func<IWebDriver, IWebElement> WaitForButtonElement()
        {
            return ((x) =>
            {
                if (x.FindElements(By.XPath("//*[@id='udemy']/div[2]/div[3]/div[1]/div/div/div[3]/div/form/span/span/button/span")).Count == 1);

                    return x.FindElement(By.XPath("//*[@id='udemy']/div[2]/div[3]/div[1]/div/div/div[3]/div/form/span/span/button/span"));
                
                return null;

            });
        }

        private Func<IWebDriver, IWebElement> WaitToSelectFromList()
        {
            return ((x) =>
            {
                if (x.FindElements(By.XPath("//*[@id='search - result - page - v3']/div/div/div[2]/div[3]/div[1]/div[2]/div[23]/div/div/a/div/div[2]/div[1]/h4")).Count == 1) ;
                    return x.FindElement(By.XPath("//*[@id='search - result - page - v3']/div/div/div[2]/div[3]/div[1]/div[2]/div[23]/div/div/a/div/div[2]/div[1]/h4"));
                return null;

                
            });
        }
    }
}
