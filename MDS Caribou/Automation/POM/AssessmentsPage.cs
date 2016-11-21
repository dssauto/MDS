using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class AssessmentsPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By batchesTransmitNavbar = By.XPath(".//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By assessmentsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/header/h1");
        static internal By allCheckBox = By.XPath("//*[@id='main-content']/div/div[1]/div/div/div/div[1]/div/label/strong");
        static internal By selectPageDropdown = By.Id("selectPageSize");
        static internal By lastScroller = By.XPath("//*[@id='main-content']/div/div[1]/div/div/div/div[3]/div/div[1]/ul/li[2]/div/a");
        static internal By selectLocationDropdown = By.Id("selectLocation");
        static internal By assessmentOneLabel = By.XPath("//*[@id='main-content']/div/div[1]/div/div/div/div[4]/div/label[1]");
        static internal By assessmentTwoLabel = By.XPath("//*[@id='main-content']/div/div[1]/div/div/div/div[4]/div/label[2]");
        static internal By createBatchButton = By.XPath("//*[@id='main-content']/div/div[1]/div/div/div/div[6]/button");
        static internal By noPAAFTMessage = By.XPath("//*[@id='main-content']/div/div[2]/div/div/div/div/p");
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
            VerifyElement.IsPresent(assessmentsNavbar);
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "Assessments");
            VerifyElement.IsPresent(allCheckBox);
            VerifyElement.IsPresent(selectPageDropdown);
            VerifyElement.IsPresent(lastScroller);
            VerifyElement.IsPresent(selectLocationDropdown);
            VerifyElement.IsPresent(assessmentOneLabel);
            VerifyElement.IsPresent(assessmentTwoLabel);
            VerifyElement.IsPresent(createBatchButton);
            VerifyElement.AreEqual(noPAAFTMessage, "No pending assessments available for this search criteria.");
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.AreEqual(userFooter, "Selenium, Facility");
            VerifyElement.IsPresent(developedByFooter);
        }

        #endregion

        #region Navigation

        public static void NavigateTo()
        {
        }
        #endregion

    }
}