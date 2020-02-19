using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.FileUpload
{
    [TestClass]
    public class TestFileUploadAction
    {
        [TestMethod,TestCategory("Smoke")]
        public void TestUpload()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ButtonHelper.ClickButton(By.Id("enter_bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            ButtonHelper.ClickButton(By.LinkText("Testng"));
            ButtonHelper.ClickButton(By.XPath("//div[@id='attachment_false']/input"));
            GenericHelper.WaitForWebElement(By.Id("data"), TimeSpan.FromSeconds(30));
            ButtonHelper.ClickButton(By.Id("data"));

            var processinfo = new ProcessStartInfo()
            {
                FileName = @"F:\Auto\FileUpload.exe",
                Arguments = @"C:\downloads\ExcelData.xlsx"
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
