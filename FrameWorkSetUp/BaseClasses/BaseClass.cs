using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Configuration;
using FrameWorkSetUp.CustomException;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace FrameWorkSetUp.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        //The following code is to run the firefox with all the extensions and favourite 
        //private static FirefoxProfile GetFirefoxOptions()
        //{
        //    FirefoxProfile profile = new FirefoxProfile();
        //    FirefoxProfileManager manager = new FirefoxProfileManager();
        //    profile = manager.GetProfile("default");
        //    return profile;
        //}
        private static ChromeOptions GetChromeOption()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("Start-maximized");
            return option;
        }

        private static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            options.ElementScrollBehavior = InternetExplorerElementScrollBehavior.Bottom;
            return options;
        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOption());
            return driver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;
                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIEDriver();
                    break;
                default:
                    throw new NoSutiableDriverFound("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString());
            }
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Manage().Timeouts().PageLoad =
                TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeout());

            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = 
                TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeout());
            BrowserHelper.BrowserMaximize();
        }

        [AssemblyCleanup]
        public static void TearDown()
        {
            if(ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
