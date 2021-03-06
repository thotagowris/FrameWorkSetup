﻿using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.ComponentHelper
{
    public class GenericHelper
    {
        // this method is only for unique element like ID
        public static bool IsElelementPresent(By Locator)
        {
            try
            {
            return ObjectRepository.Driver.FindElements(Locator).Count == 1;
            }
            catch (Exception)
            {

                return false;
            }
        } 

        public static IWebElement GetElement(By Locator)
        {
            if (IsElelementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else
            {
                throw new NoSuchElementException("Element Not Found : {0}" + Locator.ToString());
            }
        }

        public static void TakeScreenshot(string filename = "Screen.jpeg")
        {
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            if (filename.Equals("Screen"))
            {
                string name = filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".jpeg";
                screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
                return;
            }
            else
            {
                screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
            }
        }

        public static bool WaitForWebElement(By Locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            bool flag = wait.Until(WaitforWebElementFunc(Locator));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeout());
            return flag;
        }

        private static Func<IWebDriver, bool> WaitforWebElementFunc(By Locator)
        {
            return ((x) =>
            {
                if (x.FindElements(Locator).Count==1)
                
                    return true;
                return false;
                
            });
        }

        public static IWebElement WaitForWebElementInPage(By Locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            IWebElement flag = wait.Until(WaitforWebElementInPageFunc(Locator));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeout());
            return flag;
        }
        private static Func<IWebDriver, IWebElement> WaitforWebElementInPageFunc(By Locator)
        {
            return ((x) =>
            {
                if (x.FindElements(Locator).Count == 1)
                    return x.FindElement(Locator);

                    
                return null;

            });
        }

        public static WebDriverWait GetWebdriverWait(TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout)
            {
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait;
        }
    }
}
