using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.ComponentHelper
{
    public class JavaScriptPopHelper
    {
        public static bool IsPopUpPresent()
        {
            try
            {
                ObjectRepositiry.Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {

                return false;
            }
        }

        public static string GetPopUpText()
        {
            if (!IsPopUpPresent())
                return "";
            return ObjectRepositiry.Driver.SwitchTo().Alert().Text;
        }

        public static void ClickOnPopUp()
        {
            if (!IsPopUpPresent())
                return;
            ObjectRepositiry.Driver.SwitchTo().Alert().Accept();

        }

        public static void ClickCancelOnPopup()
        {
            if (!IsPopUpPresent())
                return;
            ObjectRepositiry.Driver.SwitchTo().Alert().Dismiss();
        }

        public static void sendKeys(string text)
        {
            if (!IsPopUpPresent())
                return;
            ObjectRepositiry.Driver.SwitchTo().Alert().SendKeys(text);
        }
    }
}
