using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class UserMenuTest : BaseSetup
    {
        [Test]
        public void TC016_AccountSettingsLink_Validation()
        {
            Browser.Open();
            LoginPage.SignIn();
            UserMenu.NavigateToAccountSettingsPage();
            UserMenu.SignOut();
        }
        [Test]
        public void TC017_ScheduleMenu_Validation()
        {
            Browser.Open();
            LoginPage.SignIn();
            UserMenu.NavigateToSchedulePage();
            UserMenu.SignOut();
        }
        [Test]
        public void TC018_WIPMenu_Validation()
        {
            Browser.Open();
            LoginPage.SignIn();
            UserMenu.NavigateToWIPPage();
            UserMenu.SignOut();
        }
        [Test]
        public void TC019_HistoryMenu_Validation()
        {
            Browser.Open();
            LoginPage.SignIn();
            UserMenu.NavigateToHistory();
            UserMenu.SignOut();
        }
        [Test]
        public void TC020_BatchTransmitMenu_Validation()
        {
            Browser.Open();
            LoginPage.SignIn();
            UserMenu.NavigateToBatchesPage();
            UserMenu.SignOut();
        }
        [Test]
        public void TC021_ReportsFormsMenu_Validation()
        {
            Browser.Open();
            LoginPage.SignIn();
            UserMenu.NavigateToReportsFormsPage();
            UserMenu.SignOut();
        }
        [Test]
        public void TC022_AdminMenu_Validation()
        {
            Browser.Open();
            LoginPage.SignIn();
            UserMenu.NavigateToAdminPage();
            UserMenu.SignOut();
        }
    }
}
