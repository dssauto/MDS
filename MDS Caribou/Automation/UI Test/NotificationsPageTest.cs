using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class NotificationsPageTest : BaseSetup
    {
        [Test]
        public void TC037_Notifications_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToAdminPage();
            Driver.WaitFor(2);
            AdminPage.NavigateToNotifications();
            Driver.WaitFor(2);
            VerifyElement.IsPresent(NotificationsPage.homeIcon);
            VerifyElement.IsPresent(NotificationsPage.caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(NotificationsPage.adminNavbar);
            VerifyElement.IsPresent(NotificationsPage.notificationsNavbar);
            VerifyElement.IsPresent(NotificationsPage.notificationBellIcon);
            VerifyElement.IsPresent(NotificationsPage.syncStatusIcon);
            VerifyElement.IsPresent(NotificationsPage.profileIcon);
            VerifyElement.AreEqual(NotificationsPage.pageHeader, "Notifications");
            VerifyElement.AreEqual(NotificationsPage.dateTimeColumnLabel, "Date & Time");
            VerifyElement.AreEqual(NotificationsPage.descriptionColumnLabel, "Description");
            VerifyElement.AreEqual(NotificationsPage.typeColumnLabel, "Type");
            VerifyElement.AreEqual(NotificationsPage.actionColumnLabel, "Action");
            VerifyElement.IsPresent(NotificationsPage.reloadListButton);
            VerifyElement.IsPresent(NotificationsPage.approveAccessButton);
            VerifyElement.IsPresent(NotificationsPage.clearButton);
            VerifyElement.IsPresent(NotificationsPage.previousButton);
            VerifyElement.IsPresent(NotificationsPage.nextButton);
            VerifyElement.IsPresent(NotificationsPage.caribouCLSSuiteFooter);
            VerifyElement.IsPresent(NotificationsPage.versionFooter);
            VerifyElement.IsPresent(NotificationsPage.userFooter);
            VerifyElement.IsPresent(NotificationsPage.developedByFooter);
        }
    }
}