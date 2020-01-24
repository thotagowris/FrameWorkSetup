using System;
using System.Configuration;
using FrameWorkSetUp.Configuration;
using FrameWorkSetUp.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FrameWorkSetUp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IConfig config = new AppConfigReader();
            Console.WriteLine("Browser : {0}", config.GetBrowser());
            Console.WriteLine("Username : {0}", config.GetUsername());
            Console.WriteLine("Password : {0}", config.GetPassword());
        }
    }
}
