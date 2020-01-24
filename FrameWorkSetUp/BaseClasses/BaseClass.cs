using FrameWorkSetUp.Configuration;
using FrameWorkSetUp.CustomException;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            ObjectRepositiry.config = new AppConfigReader();

            switch (ObjectRepositiry.config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepositiry.Driver = GetChromeDriver();
                    break;
                case BrowserType.Firefox:
                    ObjectRepositiry.Driver = GetFirefoxDriver();
                    break;
                case BrowserType.IExplorer:
                    ObjectRepositiry.Driver = GetIEDriver();
                    break;
                default:
                    throw new NoSutiableDriverFound("Driver Not Found : " + ObjectRepositiry.config.GetBrowser().ToString());
            }
        }
    }
}
