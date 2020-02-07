using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.ComponentHelper
{
    public class BrowserHelper
    {
        public static void BrowserMaximize()
        {
            ObjectRepositiry.Driver.Manage().Window.Maximize();
        }

        public static void GoBack()
        {
            ObjectRepositiry.Driver.Navigate().Back();
        }
        public static void Forward()
        {
            ObjectRepositiry.Driver.Navigate().Forward();
        }
        public static void Refresh()
        {
            ObjectRepositiry.Driver.Navigate().Refresh();
        }

        public static void SwitchToWindow(int index = 0)
        {
            ReadOnlyCollection<string> windows = ObjectRepositiry.Driver.WindowHandles;

            if (windows.Count < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" + index);
            }

            ObjectRepositiry.Driver.SwitchTo().Window(windows[index]);
            BrowserMaximize();
        }

        public static void WindowHandles()
        {
            ReadOnlyCollection<string> window = ObjectRepositiry.Driver.WindowHandles;
            
        }

        public static void SwitchToParent()
        {
            var windowids = ObjectRepositiry.Driver.WindowHandles;
            for (int i = windowids.Count; i > 0; i--)
            {
                ObjectRepositiry.Driver.Close();
                ObjectRepositiry.Driver.SwitchTo().Window(windowids[i]);
            }
            ObjectRepositiry.Driver.SwitchTo().Window(windowids[0]);
        }

        public static void SwitchToFrame(By Locator)
        {
            ObjectRepositiry.Driver.SwitchTo().Frame(ObjectRepositiry.Driver.FindElement(Locator));

        }
    }
}
