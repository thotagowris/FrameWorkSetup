using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.CustomException;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.KeyWord
{
    public class DataEngine
    {
        private readonly int _keywordCol;
        private readonly int _LocatorTypeCol;
        private readonly int _LocatorValueCol;
        private readonly int _parameterCol;

        public DataEngine(int keywordCol, int LocatorTypeCol, int LocatorValueCol, int parameterCol)
        {
            this._keywordCol = keywordCol;
            this._LocatorTypeCol = LocatorTypeCol;
            this._LocatorValueCol = LocatorValueCol;
            this._parameterCol = parameterCol;
        }

        private By GetElementLocator(string locatorType, string locatorValue)
        {
            switch (locatorType)
            {
                case "ClassName":
                    return By.ClassName(locatorValue);
                case "CssSelector":
                    return By.CssSelector(locatorValue);
                case "Id":
                    return By.Id(locatorValue);
                case "PartialLinkText":
                    return By.PartialLinkText(locatorValue);
                case "Name":
                    return By.Name(locatorValue);
                case "Xpath":
                    return By.XPath(locatorValue);
                case "TagName":
                    return By.TagName(locatorValue);
                case "LinkText":
                    return By.LinkText(locatorValue);
                default:
                    return By.Id(locatorValue);
                   
            }
        }

        private void PerformAction(string  , string locatorType, string locatorValue, params string[] args) 
        {
            switch (locatorType)
            {
                case "Click":
                    ButtonHelper.ClickButton(GetElementLocator(locatorType, locatorValue));
                    break;
                case "SendKeys":
                    TextBoxHelper.TypeInTextBox(GetElementLocator(locatorType, locatorValue), args[0]);
                    break;
                case "Select":
                    ComboBoxHelper.SelectElementByValue(GetElementLocator(locatorType, locatorValue), args[0]);
                    break;
                case "WaitForEle":
                    GenericHelper.WaitForWebElementInPage(GetElementLocator(locatorType, locatorValue), TimeSpan.FromSeconds(50));
                    break;
                case "Navigate":
                    NavigationHelper.NavigateToUrl(args [0]);
                    break;
                
                default:
                    throw new NoSuchKeyWordFoundException("Keyword Not Found : " + keyword);

            }
        }
    }
}
