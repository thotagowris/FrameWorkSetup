using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.DefaultWait
{
    [TestClass]
    public class HandleDefaultWait
    {
        [TestMethod]
        public void TestDefaultWait()
        {
            NavigationHelper.NavigateToUrl(ObjectRepositiry.config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepositiry.config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepositiry.config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            ObjectRepositiry.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            GenericHelper.WaitForWebElement(By.Id("bug_severity"),TimeSpan.FromSeconds(50));
            IWebElement element = GenericHelper.WaitForWebElementInPage(By.Id("bug_severity"), TimeSpan.FromSeconds(50));

            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(ObjectRepositiry.Driver.FindElement(By.Id("bug_severity")));
            wait.PollingInterval = TimeSpan.FromMilliseconds(200);
            wait.Timeout = TimeSpan.FromSeconds(50);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            Console.WriteLine("After wait : {0}", wait.Until(changeOfValue()));
        }

        private Func<IWebElement, string> changeOfValue()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for value change");
                SelectElement select = new SelectElement(x);
                if (select.SelectedOption.Text.Equals("major"))
                    return select.SelectedOption.Text;
                return null;
            });
        }

    }
}
