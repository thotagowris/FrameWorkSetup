using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace FrameWorkSetUp.ComponentHelper
{
    public class ComboBoxHelper
    {
        private static SelectElement select;

        public static void SelectElement(By Locator, int Index)
        {
            select = new SelectElement(GenericHelper.GetElement(Locator));
            select.SelectByIndex(Index);
        }

        public static void SelectElement(By Locator, string VisibleText)
        {
            select = new SelectElement(GenericHelper.GetElement(Locator));
            select.SelectByValue(VisibleText);
        }

        public static IList<string> GetAllItem(By Locator)
        {
            select = new SelectElement(GenericHelper.GetElement(Locator));
            return select.Options.Select((x) => x.Text).ToList();

        }

        public static void SelectElement(IWebElement element, string visibletext)
        {
            select = new SelectElement(element);
            select.SelectByValue(visibletext);

        }
    }
}
