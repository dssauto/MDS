using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class NursingIndexAndRUGIVReimbursementReportPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By reportsFormsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By nursingIndexAndRugIVReimbursementNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/div/header/h1");
        static internal By selectDateFilter = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div/div[1]/div/div/input");
        static internal By applyButton = By.XPath("//*[@id='mds']/div[3]/div[3]/div/button[1]");
        static internal By cancelButton = By.XPath("//*[@id='mds']/div[3]/div[3]/div/button[2]");
        static internal By selectLocationDropdown = By.Id("selectLocation");

        //Bottom
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
            VerifyElement.AreEqual(reportsFormsNavbar, "Reports & Forms");
            VerifyElement.AreEqual(nursingIndexAndRugIVReimbursementNavbar, "Nursing Index and Rug-IV Reimbursement");
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "Nursing Index and RUG-IV Reimbursement Report");
            VerifyElement.IsPresent(selectDateFilter);
            VerifyElement.IsPresent(applyButton);
            VerifyElement.IsPresent(cancelButton);
            VerifyElement.IsPresent(selectLocationDropdown);

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
