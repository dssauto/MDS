using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class UserMenu
    {
        #region WebElements
        static internal By assessmentNavbar = By.XPath("//span[@class='ng-binding']");
        static internal By vistaIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]");
        static internal By connectButton = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[4]/button");
        static internal By accessCodeTextfield = By.Id("userAccessCode");
        static internal By verifyCodeTextfield = By.Id("userVerifyCode");
        static internal By accountSettingsLink = By.XPath("//a[@href='/CaribouCLCSuite/menu/useraccountsettings']");

        static internal By scheduleIcon = By.XPath("(//ul/li[@class='ng-scope'][contains(., 'Schedule')])[1]");
        static internal By wipIcon = By.XPath("//ul/li[@class='ng-scope'][contains(., 'Work In Progress')]");
        static internal By historyIcon = By.XPath("(//ul/li[@class='ng-scope'][contains(., 'History')])[1]");
        static internal By batchTransmitIcon = By.XPath("(//ul/li[@class='ng-scope'][contains(., 'Batch & Transmit')])[1]");
        static internal By reportsFormsIcon = By.XPath("(//ul/li[@class='ng-scope'][contains(., 'Reports & Forms')])[1]");
        static internal By adminIcon = By.XPath("(//ul/li[@class='ng-scope'][contains(., 'Admin')])[1]");
        static internal By signoutButton = By.XPath("//button[normalize-space(text())='Sign Out']");
        static internal By userIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]");
        static internal By successMessage = By.XPath("//*[@id='toast-container']/div/div[1]");
        static internal By notificationsIcon = By.XPath("//div[@class='notifications-button ng-scope']");
        static internal By caribouCLCSuiteLink = By.XPath("(//ol[@class='breadcrumb']/li/a)[4]");
        static internal By caribouCLCSuiteBreadcrumb = By.XPath("//a[@ui-sref='landing.menu']");
        static internal By scheduleNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By seeAllButton = By.XPath("//button[@class='btn btn-info btn-block']");
        static internal By notificationsNavbar = By.XPath("//ui-breadcrumbs/ol/li[3]/span");
        static internal By userAccountNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By wipNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By searchResidentsNavbar = By.XPath("(//span[@class='ng-binding'])[1]");
        static internal By searchResidentsNavbarLink = By.XPath("//a[@href='/CaribouCLCSuite/menu/history']");
        static internal By batchesTransmitNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By adminNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By reportsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By loginButton = By.XPath("//button[@type='submit']");
        static internal By homeIcon = By.XPath("(//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li/span)[1]");
        static internal By syncIcon = By.XPath("//div[@class='sync-button ng-scope']");
        static internal By syncBtn = By.XPath("//button[@ng-click='syncVistA()']");
        static internal By batchesNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");

        #endregion

        #region Action
        internal static void SYNC()
        {
            Driver.ClickOn(syncIcon);
            Driver.ClickOn(syncBtn);
        }
        public static void VistASync()
        {
            //Driver.WaitFor(4);
            Driver.PressEnter(vistaIcon);
            Driver.PressEnter(connectButton);
            Driver.InsertText(accessCodeTextfield, "rairac123.");
            Driver.InsertText(verifyCodeTextfield, "rairac123!");
            Driver.PressEnter(loginButton);
            VerifyElement.AreEqual(successMessage, "Successful Authentication");
        }
        public static void VerifyPageElements()
        {
            VerifyElement.AreEqual(homeIcon, "Caribou CLC Suite");
            VerifyElement.IsPresent(notificationsIcon);
            VerifyElement.IsPresent(userIcon);
        }
        public static void SignOut()
        {
            Driver.WaitForElement(userIcon);
            Driver.PressEnter(userIcon);
            Driver.PressEnter(signoutButton);
        }
        #endregion

        #region Navigation
        public static void NavigateToNotificationsPage()
        {
            Driver.PressEnter(notificationsIcon);
            Driver.PressEnter(seeAllButton);
            VerifyElement.AreEqual(notificationsNavbar, "Notifications");
        }
        public static void NavigateToAccountSettingsPage()
        {
            Driver.PressEnter(userIcon);
            Driver.PressEnter(accountSettingsLink);
            VerifyElement.AreEqual(userAccountNavbar, "User Account");
        }
        public static void NavigateToSchedulePage()
        {
            Driver.PressEnter(userIcon);
            Driver.PressEnter(scheduleIcon);
            VerifyElement.AreEqual(scheduleNavbar, "Schedule");

        }
        public static void NavigateToWIPPage()
        {
            Driver.PressEnter(userIcon);
            Driver.PressEnter(wipIcon);
            VerifyElement.AreEqual(wipNavbar, "Work In Progress");
        }
        public static void NavigateToHistory()
        {
            Driver.PressEnter(userIcon);
            Driver.PressEnter(historyIcon);
            VerifyElement.AreEqual(searchResidentsNavbar, "Search Residents");
        }
        public static void NavigateToBatchesPage()
        {
            Driver.PressEnter(userIcon);
            Driver.PressEnter(batchTransmitIcon);
            VerifyElement.AreEqual(batchesTransmitNavbar, "Batches & Transmit");
            VerifyElement.AreEqual(batchesNavbar, "Batches");
        }
        public static void NavigateToReportsFormsPage()
        {
            Driver.PressEnter(userIcon);
            Driver.PressEnter(reportsFormsIcon);
            VerifyElement.AreEqual(reportsNavbar, "Reports & Forms");
        }
        public static void NavigateToAdminPage()
        {
            Driver.PressEnter(userIcon);
            Driver.PressEnter(adminIcon);
            VerifyElement.AreEqual(adminNavbar, "Admin");
        }
        #endregion
    }
}
