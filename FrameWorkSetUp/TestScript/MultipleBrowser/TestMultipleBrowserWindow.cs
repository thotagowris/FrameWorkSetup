using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.MultipleBrowser
{
    [TestClass]
    public class TestMultipleBrowserWindow
    {
        [TestMethod]
        public void TestMultipleBrowserWindows()
        {
            NavigationHelper.NavigateToUrl("http://uitestpractice.com/Students/Switchto");
            ReadOnlyCollection<string> window = ObjectRepositiry.Driver.WindowHandles;
            Console.WriteLine("Before Click");
            //Thread.Sleep(4000);
            Console.WriteLine("Number of windows open by selenium : " + window.Count);
            foreach (var item in window)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Current Window Handle: " + window);

            
            ButtonHelper.ClickButton(By.LinkText("Opens in a new window"));
            //GenericHelper.WaitForWebElement(By.Id("draggable"), TimeSpan.FromSeconds(50));
            Thread.Sleep(2000);
            Console.WriteLine("After Click");
            Console.WriteLine("Number of windows opened by selenium :" + window.Count);
            foreach (var item in window)
            {
                Console.WriteLine(item);
            }

            BrowserHelper.SwitchToWindow(1);
            Console.WriteLine(ObjectRepositiry.Driver.FindElement(By.Id("draggable")).Text);
            Console.WriteLine("Current Window handle " + ObjectRepositiry.Driver.CurrentWindowHandle);

            Console.WriteLine("After Close");
            ObjectRepositiry.Driver.Close();
            Console.WriteLine("Number of windows open by selenium : " + window.Count);
            foreach (var item in window)
            {
                Console.WriteLine(item);
            }
            BrowserHelper.SwitchToWindow(0);
            Console.WriteLine("Current Window handle " + ObjectRepositiry.Driver.CurrentWindowHandle);
        }
    }
}
