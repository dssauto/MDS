using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class LandingPage
    {
        #region WebElements
        static internal By userIcon = By.XPath("//div[@class='circle-button']");
        static internal By notificationsIcon = By.XPath("//div[@class='circle-button']");
        static internal By homeIcon = By.XPath("//ol[@class='breadcrumb']/li/span");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/h1");
        static internal By scheduleTile = By.XPath("//ul[@class='landing_tiles list-unstyled list-inline']/li[contains(., 'Schedule')]");
        static internal By workInProgressTile = By.XPath("//ul[@class='landing_tiles list-unstyled list-inline']/li[contains(., 'Work In Progress')]");
        static internal By residentHistoryTile = By.XPath("//ul[@class='landing_tiles list-unstyled list-inline']/li[contains(., 'Resident History')]");
        static internal By batchTransmitTile = By.XPath("//*[@id='main-content']/div/div/ul/li[4]");
        static internal By reportsFormsTile = By.XPath("//*[@id='main-content']/div/div/ul/li[5]");
        static internal By adminTile = By.XPath("//ul[@class='landing_tiles list-unstyled list-inline']/li[contains(., 'Admin')]");
        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("Caribou CLC Suite");
            Driver.WaitForPageLoad();
            VerifyElement.IsPresent(pageHeader);
            VerifyElement.IsPresent(scheduleTile);
            VerifyElement.IsPresent(workInProgressTile);
            VerifyElement.IsPresent(residentHistoryTile);
            VerifyElement.IsPresent(batchTransmitTile);
            VerifyElement.IsPresent(reportsFormsTile);
            VerifyElement.IsPresent(adminTile);
            Footer.VerifyPageElements();
            UserMenu.VerifyPageElements();
        }
        #endregion

        #region Navigation
        public static void NavigateToSchedulePage()
        {
            Driver.PressEnter(scheduleTile);
            VerifyElement.AreEqual(UserMenu.scheduleNavbar, "Schedule");
        }
        public static void NavigateToWorkInProgressPage()
        {
            Driver.PressEnter(workInProgressTile);
            VerifyElement.AreEqual(UserMenu.wipNavbar, "Work In Progress");
        }
        public static void NavigateToResidentHistoryPage()
        {
            Driver.PressEnter(residentHistoryTile);
            VerifyElement.AreEqual(UserMenu.searchResidentsNavbar, "Search Residents");
        }
        public static void NavigateToBatchesTransmitPage()
        {
            Driver.PressEnter(batchTransmitTile);
            VerifyElement.AreEqual(UserMenu.batchesTransmitNavbar, "Batches & Transmit");
        }
        public static void NavigateToReportsFormsPage()
        {
            Driver.ClickOn(reportsFormsTile);
            VerifyElement.AreEqual(UserMenu.reportsNavbar, "Reports & Forms");
        }
        public static void NavigateToAdminPage()
        {
            Driver.PressEnter(adminTile);
            VerifyElement.AreEqual(UserMenu.adminNavbar, "Admin");
        }
        #endregion

    }
}
