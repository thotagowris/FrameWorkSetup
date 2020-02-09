using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.AutoSuggest
{
    [TestClass]
    public class TestAutoSuggest
    {
        [TestMethod]
        public void TestAutoSug()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/autocomplete/index");
            Actions act = new Actions(ObjectRepositiry.Driver);
            IWebElement ele = ObjectRepositiry.Driver.FindElement(By.Id("countries"));
            ele.SendKeys("a");
            Thread.Sleep(2000);
            // Wait for auto suggest list

            var wait = GenericHelper.GetWebdriverWait(TimeSpan.FromSeconds(40));
            IList<IWebElement> elements = wait.Until(GetAllElement(By.XPath("//ul[@id='countries_listbox']")));
            foreach (var ele1 in elements)
            {
                if (ele1.Text.Equals("Azerbaijan"))
                {
                    ele1.Click();
                }
                else
                {
                    Console.WriteLine("Element Not Present");
                }
            }
            Thread.Sleep(5000);
        }

        private Func<IWebDriver, IList<IWebElement>> GetAllElement(By locator)
        {
            return ((x) => 
            {
                return x.FindElements(locator);
            });
        }
    }
}
