using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameWorkSetUp.Settings;
using OpenQA.Selenium;
using FrameWorkSetUp.ComponentHelper;

namespace FrameWorkSetUp.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine("Title of page : {0}", WindowHelper.GetTitle());
        }
    }
}
 