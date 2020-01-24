using FrameWorkSetUp.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.Settings
{
    public class ObjectRepositiry
    {
        public static IConfig config {get; set;}
        public static IWebDriver Driver {get; set; }

    }
}
