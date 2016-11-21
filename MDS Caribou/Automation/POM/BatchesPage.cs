using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class BatchesPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By batchesTransmitNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By batchesNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/header/h1");
        static internal By dateRangeField = By.Id("dateRangePicker");
        static internal By applyButton = By.XPath("//*[@id='mds']/div[3]/div[3]/div/button[1]");
        static internal By cancelButton = By.XPath("//*[@id='mds']/div[3]/div[3]/div/button[2]");
        static internal By resetFilterButton = By.XPath("//*[@id='main-content']/div/div[1]/div/div/div/div[1]/div/div[2]/button");
        static internal By noBatchesAvailableInLast30DaysMessage = By.XPath("//*[@id='main-content']/div/div[2]/div[1]/div/div/p");
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");
        static internal By assessmentsTile = By.XPath("//*[@id='main-content']/div/div/ul/li[1]");
        static internal By batchesTile = By.XPath("//*[@id='main-content']/div/div/ul/li[2]");
        
        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.IsPresent(homeIcon);
            VerifyElement.IsPresent(caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(batchesTransmitNavbar);
            VerifyElement.IsPresent(batchesNavbar);
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "Batches");
            VerifyElement.IsPresent(dateRangeField);
            Driver.ClickOn(By.XPath("//*[@id='dateRangePicker']"));
            VerifyElement.IsPresent(applyButton);
            VerifyElement.IsPresent(cancelButton);
            Driver.ClickOn(By.XPath("//*[@id='mds']/div[3]/div[3]/div/button[2]"));
            VerifyElement.IsPresent(resetFilterButton);
            VerifyElement.AreEqual(noBatchesAvailableInLast30DaysMessage, "No batches available in last 30 days, expand date range.");
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.AreEqual(userFooter, "Selenium, Facility");
            VerifyElement.AreEqual(developedByFooter, "Developed by DSS, Inc. © 2016");
        }

        #endregion

        #region Navigation

        public static void NavigateToAssessments()
        {
            Driver.ClickOn(assessmentsTile);
            VerifyElement.AreEqual(AssessmentsPage.pageHeader, "Assessments");  
        }

        public static void NavigateToBatches()
        {
            Driver.ClickOn(batchesTile);
            VerifyElement.AreEqual(BatchesPage.pageHeader, "Batches");

        }
        #endregion

    }
}