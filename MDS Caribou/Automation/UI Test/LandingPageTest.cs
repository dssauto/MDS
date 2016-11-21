using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
namespace Automation.UI_Test
{
    [TestFixture]
    class LandingPageTest : BaseSetup
    {
        [Test]
        public void TC007_VerifyPageElementsLandingPage()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.VerifyPageElements();
            UserMenu.SignOut();
        }
        [Test]
        public void TC008_NavigateTo_SchedulePage()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToSchedulePage();
        }
        [Test]
        public void TC009_NavigateTo_WorkInProgressPage()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToWorkInProgressPage();
        }
        [Test]
        public void TC010_NavigateTo_ResidentHistoryPage()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToResidentHistoryPage();
        }
        [Test]
        public void TC011_NavigateTo_BatchTransmitPage()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToBatchesTransmitPage();
        }
        [Test]
        public void TC012_NavigateTo_ReportsFormsPage()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToReportsFormsPage();
        }
        [Test]
        public void TC013_NavigateTo_AdminPage()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToAdminPage();
        }
        [Test]
        public void TC014_NavigateTo_NotificationsPage()
        {
            Browser.Open();
            LoginPage.SignIn();
            UserMenu.NavigateToNotificationsPage();
        }
        [Test]
        public void TC015_UserMenu_SignOut_Validation()
        {
            Browser.Open();
            LoginPage.SignIn();
            UserMenu.SignOut();
            VerifyElement.AreEqual(LoginPage.pageHeader, "Caribou CLC Suite");
        }
    }
}
