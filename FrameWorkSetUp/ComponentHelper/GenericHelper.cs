using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
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
            return ObjectRepositiry.Driver.FindElements(Locator).Count == 1;
            }
            catch (Exception)
            {

                return false;
            }
        } 

        public static IWebElement GetElement(By Locator)
        {
            if (IsElelementPresent(Locator))
                return ObjectRepositiry.Driver.FindElement(Locator);
            else
            {
                throw new NoSuchElementException("Element Not Found : {0}" + Locator.ToString());
            }
        }
    }
}
