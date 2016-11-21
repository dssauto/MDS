using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class NotificationsPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By adminNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By notificationsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/header/h1");

        static internal By dateTimeColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[1]/table/thead/tr/td[1]");
        static internal By descriptionColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[1]/table/thead/tr/td[2]");
        static internal By typeColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[1]/table/thead/tr/td[3]");
        static internal By actionColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[1]/table/thead/tr/td[4]");
        static internal By reloadListButton = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[1]/table/thead/tr/td[5]/button");

        static internal By approveAccessButton = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[1]/table/tbody/tr/td[4]/button");
        static internal By clearButton = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[1]/table/tbody/tr/td[5]/button");
        static internal By previousButton = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[2]/ul/li[1]/a");
        static internal By nextButton = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[2]/ul/li[3]/a");

        //Bottom
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");

        static internal By unlockAccountBtn = By.XPath("");


        #endregion

        #region Action

        public static void VerifyPageElements()
        {

            VerifyElement.IsPresent(homeIcon);
            VerifyElement.IsPresent(caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(adminNavbar);
            VerifyElement.IsPresent(notificationsNavbar);
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "Notifications");
            VerifyElement.AreEqual(dateTimeColumnLabel, "Date & Time");
            VerifyElement.AreEqual(descriptionColumnLabel, "Description");
            VerifyElement.AreEqual(typeColumnLabel, "Type");
            VerifyElement.AreEqual(actionColumnLabel, "Action");
            VerifyElement.IsPresent(reloadListButton);
            VerifyElement.IsPresent(approveAccessButton);
            VerifyElement.IsPresent(clearButton);
            VerifyElement.IsPresent(previousButton);
            VerifyElement.IsPresent(nextButton);

            //Bottom
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
            VerifyElement.IsPresent(developedByFooter);
        }
        #endregion

        #region Navigation


        #endregion
    }
}