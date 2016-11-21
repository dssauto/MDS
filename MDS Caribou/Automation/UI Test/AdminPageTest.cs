using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class AdminPageTest : BaseSetup
    {
        [Test]
        public void TC023_Admin_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToAdminPage();
            Driver.WaitFor(2);
            VerifyElement.IsPresent(AdminPage.homeIcon);
            VerifyElement.IsPresent(AdminPage.caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(AdminPage.adminNavbar);
            VerifyElement.IsPresent(AdminPage.notificationBellIcon);
            VerifyElement.IsPresent(AdminPage.syncStatusIcon);
            VerifyElement.IsPresent(AdminPage.profileIcon);
            VerifyElement.AreEqual(AdminPage.pageHeader, "Admin");
            VerifyElement.IsPresent(AdminPage.caribouCLSSuiteFooter);
            VerifyElement.IsPresent(AdminPage.versionFooter);
            VerifyElement.IsPresent(AdminPage.userFooter);
            VerifyElement.IsPresent(AdminPage.developedByFooter);
        }

    }
}