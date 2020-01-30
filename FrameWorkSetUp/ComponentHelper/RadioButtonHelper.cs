using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.ComponentHelper
{
    public class RadioButtonHelper
    {
        private static IWebElement element;

        public static void ClickRadioButton(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Click();
        }

        public static bool IsRadioButtonSelected(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            string flag = element.GetAttribute("checked");

            if (flag == null)
            {
                return false;
            }
            else
            {
                return flag.Equals("true") || flag.Equals("checked");
            }
        }

    }
}
