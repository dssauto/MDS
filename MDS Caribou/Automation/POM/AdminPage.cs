using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class AdminPage
    {
        #region WebElements

        //Navigation Pane
        static internal By usersRolesTab = By.XPath("//*[@id='leftside-navigation']/ul/li[1]/a/span");
        static internal By facilitySettingsTab = By.XPath("//*[@id='leftside-navigation']/ul/li[2]/a/span");
        static internal By rugRatesTab = By.XPath("//*[@id='leftside-navigation']/ul/li[3]/a/span");
        static internal By notificationsTab = By.XPath("//*[@id='leftside-navigation']/ul/li[4]/a/span");

        //Main
        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By adminNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='mds']/div[1]/div/section/section/div/div/div/div[2]/h1");
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.IsPresent(usersRolesTab);
            VerifyElement.IsPresent(facilitySettingsTab);
            VerifyElement.IsPresent(rugRatesTab);
            VerifyElement.IsPresent(notificationsTab);
            VerifyElement.IsPresent(homeIcon);
            VerifyElement.IsPresent(caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(adminNavbar);
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "Admin");
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
            VerifyElement.IsPresent(developedByFooter);
        }

        #endregion

        #region Navigation

        public static void NavigateToUsersRoles()
        {
            Driver.ClickOn(usersRolesTab);
            VerifyElement.AreEqual(UsersRolesPage.facilityUsersNavbar, "Facility Users");
        }

        public static void NavigateToFacilitySettings()
        {
            Driver.ClickOn(facilitySettingsTab);
            VerifyElement.AreEqual(FacilitySettingsPage.pageHeader, "Facility Settings");
        }

        public static void NavigateToRugRates()
        {
            Driver.ClickOn(rugRatesTab);
            VerifyElement.AreEqual(RugRatesPage.pageHeader, "RUG-IV 66 Grouper");
        }

        public static void NavigateToNotifications()
        {
            Driver.ClickOn(notificationsTab);
            VerifyElement.AreEqual(NotificationsPage.pageHeader, "Notifications");
        }
        #endregion

    }
}