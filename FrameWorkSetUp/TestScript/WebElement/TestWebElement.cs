using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]
        public void GetElement()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            try
            {
                ReadOnlyCollection<IWebElement> col = ObjectRepository.Driver.FindElements(By.TagName("input"));
                Console.WriteLine("Size : {0}", col.Count);
                Console.WriteLine("Size : {0}", col.ElementAt(0));
                //ObjectRepositiry.Driver.FindElement(By.TagName("input"));
                //ObjectRepositiry.Driver.FindElement(By.ClassName("btn"));
                //ObjectRepositiry.Driver.FindElement(By.CssSelector("#find"));
                //ObjectRepositiry.Driver.FindElement(By.LinkText("File a Bug"));
                //ObjectRepositiry.Driver.FindElement(By.PartialLinkText("File"));
                //ObjectRepositiry.Driver.FindElement(By.Name("quicksearch"));
                //ObjectRepositiry.Driver.FindElement(By.Id("find_bottom"));
                //ObjectRepositiry.Driver.FindElement(By.XPath("//input[@id='find']"));
                //    //ObjectRepositiry.Driver.FindElement(By.XPath("//input[@id='find1']"));
                //    IList<string> list = new List<string>();
                //    list.Add("Teask 1");
                //    list.Add("Teask 2");
                //    list.Add("Teask 3");
                //    Console.WriteLine("Size : {0}", list.Count);
                //    list.Remove("Task 2");
                //    Console.WriteLine("Size : {0}", list.Count);
                //    Console.WriteLine("Value : {0}", list[0]);
                //    list.Clear();
                //    Console.WriteLine("Size : {0}", list.Count);
            }
            catch (NoSuchElementException e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
