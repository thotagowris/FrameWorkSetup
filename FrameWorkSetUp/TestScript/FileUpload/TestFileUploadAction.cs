using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.FileUpload
{
    [TestClass]
    public class TestFileUploadAction
    {
        [TestMethod]
        public void TestUpload()
        {
            //[TestMethod, TestCategory("Smoke")]
        
            NavigationHelper.NavigateToUrl(ObjectRepositiry.config.GetWebsite());
            ButtonHelper.ClickButton(By.Id("enter_bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepositiry.config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepositiry.config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            //ButtonHelper.ClickButton(By.LinkText("Testng"));
            ButtonHelper.ClickButton(By.CssSelector("#attachment_false > input:nth-child(1)"));
            IWebElement elem = ObjectRepositiry.Driver.FindElement(By.XPath("//*[@id='data']"));
            // Mention the path of file to do the upload
            elem.SendKeys(@"C:\Users\Gowri Thota\FrameWorkSetup\ExcelData.xlsx");
            ////GenericHelper.WaitForWebElement(By.CssSelector("data"), TimeSpan.FromSeconds(30));
            ////ButtonHelper.ClickButton(By.CssSelector("#data"));

            var processinfo = new ProcessStartInfo()
            {
                FileName = @"C:\Users\Gowri Thota\FrameWorkSetup\File-Upload\FileUpload.exe",
                Arguments = @"C:\Users\Gowri Thota\FrameWorkSetup\ExcelData.xlsx"
            };

            //processinfo.FileName = @"F:\Auto\FileUpload.exe";
            //processinfo.Arguments = @"C:\downloads\ExcelData.xlsx";

            //Process process = Process.Start(processinfo);
            //process.WaitForExit();
            //process.Close();

            using (var process = Process.Start(processinfo))
            {
                process.WaitForExit();
            }


            Thread.Sleep(5000);

        }
    
    }
}
