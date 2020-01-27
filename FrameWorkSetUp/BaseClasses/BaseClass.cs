using FrameWorkSetUp.Configuration;
using FrameWorkSetUp.CustomException;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

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
            InternetExplorerOptions option = new InternetExplorerOptions();
            option.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            option.EnsureCleanSession = true;
            return option;
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
        [AssemblyCleanup]
        public static void TearDown()
        {
            if(ObjectRepositiry.Driver != null)
            {
                ObjectRepositiry.Driver.Close();
                ObjectRepositiry.Driver.Quit();
            }
        }
    }
}
