using FrameWorkSetUp.ComponentHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkSetUp.PageObject
{
    public class BugDetailGeneric
    {
        #region WebElement

        private By severityDropDown = By.Id("bug_severity");

        #endregion

        #region Action

        public void SelectFromSeverity(string value)
        {
            ComboBoxHelper.SelectElement(severityDropDown, value);
            
        }
        #endregion
    }
}
