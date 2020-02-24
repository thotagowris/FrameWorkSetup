using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace FrameWorkSetUp.TestScript.ScreenShot
{
    [TestClass]
    public class TakeScreenShots
    {
        [TestMethod]
        public void ScreenShot()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            //Screenshot screen = ObjectRepositiry.Driver.TakeScreenshot();
            //screen.SaveAsFile("Screen.jpeg", ScreenshotImageFormat.Jpeg);
            GenericHelper.TakeScreenshot();
            GenericHelper.TakeScreenshot("Test.jpeg");
        }
    }
}
