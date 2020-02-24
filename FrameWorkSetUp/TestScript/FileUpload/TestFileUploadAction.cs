using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.FileUpload
{
    [TestClass]
    public class TestFileUploadAction
    {
        [TestMethod, TestCategory("Smoke")]
        [DeploymentItem("Resources", "Test")]
        public void TestUpload()
        {
            //[TestMethod, TestCategory("Smoke")]
        
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ButtonHelper.ClickButton(By.Id("enter_bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            //ButtonHelper.ClickButton(By.LinkText("Testng"));
            ButtonHelper.ClickButton(By.CssSelector("#attachment_false > input:nth-child(1)"));
            IWebElement elem = ObjectRepository.Driver.FindElement(By.XPath("//*[@id='data']"));
            // Mention the path of file to do the upload
            elem.SendKeys(@"C:\Development\Repos\FrameWorkSetUp\FrameWorkSetUp\Resources\ExcelData.xlsx");
            ////GenericHelper.WaitForWebElement(By.CssSelector("data"), TimeSpan.FromSeconds(30));
            ////ButtonHelper.ClickButton(By.CssSelector("#data"));
            ///
            //Console.WriteLine(@"C:\Development\Repos\FrameWorkSetUp\FrameWorkSetUp\Resources\ExcelData.xlsx");

            //var processinfo = new ProcessStartInfo()
            //{
            //    FileName = "FileUpoad.exe",
            //    Arguments = "\"" + Directory.GetCurrentDirectory() + @"\ExcelData.xlsx" + "\""
            //};

            ////processinfo.FileName = @"F:\Auto\FileUpload.exe";
            ////processinfo.Arguments = @"C:\downloads\ExcelData.xlsx";

            ////Process process = Process.Start(processinfo);
            ////process.WaitForExit();
            ////process.Close();

            //using (var process = Process.Start(processinfo))
            //{
            //    process.WaitForExit();
            //}


            Thread.Sleep(5000);

        }
    
    }
}
