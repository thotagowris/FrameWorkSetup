using FrameWorkSetUp.ComponentHelper;
using FrameWorkSetUp.PageObject;
using FrameWorkSetUp.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FrameWorkSetUp.StepDefinition
{
    [Binding]
    public class TestFeature
    {
        private HomePage hPage;
        private LoginPage lPage;
        //private EnterBug ePage;
        private BugDetail bPage;

        #region Given

        [Given(@"User is at Home Page")]
        public void GivenUserIsAtHomePage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }

        [Given(@"File a Bug should be visible")]
        public void GivenFileABugShouldBeVisible()
        {
        }

        #endregion

        #region When

        [When(@"I click on File a Bug Link")]
        public void WhenIClickOnFileABugLink()
        {
            hPage = new HomePage(ObjectRepository.Driver);
            lPage = hPage.NavigateToLogin();
        }

        [When(@"I provide the username, password and click on Login button")]
        public void WhenIProvideTheUsernamePasswordAndClickOnLoginButton()
        {
            bPage = lPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
        }

        [When(@"I click on Logout button")]
        public void WhenIClickOnLogoutButton()
        {
            bPage.Logout();
        }


        [When(@"I provide the severity , harware , platform and summary")]
        public void WhenIProvideTheSeverityHarwarePlatformAndSummary()
        {
            bPage.SelectFromCombo("critical", "Macintosh", "Other");
            bPage.TypeIn("Summary 1", "Desc - 1");
        }

        #endregion

        #region Then

        [Then(@"User should be at Login Page")]
        public void ThenUserShouldBeAtLoginPage()
        {
        }

        [Then(@"User Should be at Enter Bug page")]
        public void ThenUserShouldBeAtEnterBugPage()
        {
        }

        [Then(@"User should be logged out and should be at Home Page")]
        public void ThenUserShouldBeLoggedOutAndShouldBeAtHomePage()
        {
        }

        [Then(@"Bug should get created")]
        public void ThenBugShouldGetCreated()
        {
        }


        #endregion

        #region And

        [When(@"click on Submit button")]
        public void WhenClickOnSubmitButton()
        {
            bPage.ClickSubmit();
        }

        [Then(@"User should be at Search page")]
        public void ThenUserShouldBeAtSearchPage()
        {
        }

        #endregion


    }
}
