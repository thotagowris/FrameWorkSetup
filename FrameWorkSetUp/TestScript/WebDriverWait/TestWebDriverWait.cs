using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.WebDriverWait
{
    [TestClass]
    public class TestWebDriverWait
    {
        [TestMethod]
        public void TestWait()
        {
            NavigationHelper.NavigateToUrl("https://www.udemy.com/courses/");
            ObjectRepositiry.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(50);
            TextBoxHelper.TypeInTextBox(By.ClassName("c_quick-search__form pos-r"), "c#");

        }
    }
}
