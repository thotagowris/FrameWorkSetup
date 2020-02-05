using FrameWorkSetUp.Settings;
using System;
using System.Collections.Generic;
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
    }
}
