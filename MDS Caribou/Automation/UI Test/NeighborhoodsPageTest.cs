using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class NeighborhoodsPageTest : BaseSetup
    {
        [Test]
        public void TC036_Neighborhoods_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToReportsFormsPage();
            Driver.WaitFor(2);
            DashboardPage.NavigateToCMS802();
            Driver.WaitFor(2);
            Driver.ClickOn(CMS802Page.createNewButton);
            Driver.WaitFor(2);
            VerifyElement.AreEqual(CMS802Page.neighborhoodsHeader, "Neighborhoods");
            VerifyElement.AreEqual(CMS802Page.selectNeighborhoodLabel, "Select Neighborhood");
            VerifyElement.IsPresent(CMS802Page.selectNeighborhoodDropdown);
            VerifyElement.IsPresent(CMS802Page.cancelButton);
            VerifyElement.IsPresent(CMS802Page.confrimButton);
        }
    }
}