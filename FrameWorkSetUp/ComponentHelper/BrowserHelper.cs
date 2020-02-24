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
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        public static void GoBack()
        {
            ObjectRepository.Driver.Navigate().Back();
        }
        public static void Forward()
        {
            ObjectRepository.Driver.Navigate().Forward();
        }
        public static void Refresh()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }

        public static void SwitchToWindow(int index = 0)
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;

            if (windows.Count < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" + index);
            }

            ObjectRepository.Driver.SwitchTo().Window(windows[index]);
            BrowserMaximize();
        }

        public static void WindowHandles()
        {
            ReadOnlyCollection<string> window = ObjectRepository.Driver.WindowHandles;
            
        }

        public static void SwitchToParent()
        {
            var windowids = ObjectRepository.Driver.WindowHandles;
            for (int i = windowids.Count; i > 0; i--)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.SwitchTo().Window(windowids[i]);
            }
            ObjectRepository.Driver.SwitchTo().Window(windowids[0]);
        }

        public static void SwitchToFrame(By Locator)
        {
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(Locator));

        }
    }
}
