using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrameWorkSetUp.TestScript.Mouse_Action
{
    [TestClass]
    public class TestMouseAction
    {
        [TestMethod]
        public void TestContextClick()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            Actions act = new Actions(ObjectRepositiry.Driver);
            IWebElement ele = ObjectRepositiry.Driver.FindElement(By.Id("draggable"));
            act = act.ContextClick(ele);
            IAction iact = act.Build();
            iact.Perform();

            act.ContextClick(ele)
                .Build()
                .Perform();

            Thread.Sleep(2000);
        }

        [TestMethod]
        public void DragNDrop()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            Actions act = new Actions(ObjectRepositiry.Driver);
            IWebElement src = ObjectRepositiry.Driver.FindElement(By.Id("draggable"));
            IWebElement tar = ObjectRepositiry.Driver.FindElement(By.Id("droptarget"));

            act.DragAndDrop(src, tar)
                .Build()
                .Perform();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestClickNHold()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/sortable/index");
            Actions act = new Actions(ObjectRepositiry.Driver);
            IWebElement ele = ObjectRepositiry.Driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div[2]/div/div/ul/li[12]"));
            IWebElement tar = ObjectRepositiry.Driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div[2]/div/div/ul/li[2]"));
            act.ClickAndHold(ele)
            .MoveToElement(tar,0,30)
            .Release()
            .Build()
            .Perform();

            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestKeyBoard()
        {
            NavigationHelper.NavigateToUrl(ObjectRepositiry.config.GetWebsite());
            var act = new Actions(ObjectRepositiry.Driver);
            //act.KeyDown(Keys.LeftControl)
            //.SendKeys("t")
            //.KeyUp(Keys.LeftControl)
            //.Build()
            //.Perform();

            //act.KeyDown(Keys.LeftControl)
            //    .KeyDown(Keys.LeftShift)
            //    .SendKeys("a")
            //    .KeyUp(Keys.LeftShift)
            //    .KeyUp(Keys.LeftControl)
            //    .Build()
            //    .Perform();

            //act.KeyDown(Keys.LeftAlt)
            //    .SendKeys("f")
            //    .SendKeys("x")
            //    .Build()
            //    .Perform();

            IWebElement ele = ObjectRepositiry.Driver.FindElement(By.Id("quicksearch_top"));
            IWebElement ele2 = ObjectRepositiry.Driver.FindElement(By.Id("quicksearch_main"));
            ele.SendKeys("test");

            act.KeyDown(ele2, Keys.LeftShift)
                .SendKeys(ele2,"f")
                .SendKeys(ele2,"x")
                .KeyUp(ele2,Keys.LeftShift)
                .Build()
                .Perform();

            Thread.Sleep(5000);
        }
    }
}
