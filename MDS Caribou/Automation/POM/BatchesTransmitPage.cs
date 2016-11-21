using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class BatchesTransmitPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By batchesTransmitNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By assessmentsTile = By.XPath("//*[@id='main-content']/div/div/ul/li[1]");
        static internal By batchesTile = By.XPath("//*[@id='main-content']/div/div/ul/li[2]");
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.IsPresent(homeIcon);
            VerifyElement.IsPresent(caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(batchesTransmitNavbar);
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.IsPresent(assessmentsTile);
            VerifyElement.IsPresent(batchesTile);
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
            VerifyElement.IsPresent(developedByFooter);
        }

        #endregion

        #region Navigation

        public static void NavigateToAssessmentsPage()
        {
            Driver.ClickOn(assessmentsTile);
            VerifyElement.AreEqual(AssessmentsPage.pageHeader, "Assessments");
        }

        public static void NavigateToBatchesPage()
        {
            Driver.ClickOn(batchesTile);
            VerifyElement.AreEqual(BatchesPage.pageHeader, "Batches");
        
        }
        #endregion

    }
}