using Framework.Base;
using Framework.POM;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;

namespace Automation.POM
{
    class MDSMasterResidentListPage : BaseSetup
    {
        #region WebElements
        static internal By confirmBtn = By.XPath("//button[@ng-click='ok()']");
        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By reportsFormsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By mdsMasterResidentListNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/div/header/h1");
        static internal By selectNeighborhoodDropdown = By.Id("selectNeighborhood");
        static internal By createReportButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[2]/button");
        //Bottom
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");
        #endregion

        #region Action
        internal static void VerifyColumnList(string v)
        {
            Driver.WaitFor(2);
            IList<IWebElement> all = Driver.Instance.FindElements(By.XPath(v));
            String[] allText = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                TestReport.Log(LogStatus.Info, allText[i++] = element.Text);
            }
        }
        public static void VerifyPageElements()
        {
            VerifyElement.IsPresent(homeIcon);
            VerifyElement.IsPresent(caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(reportsFormsNavbar);
            VerifyElement.IsPresent(mdsMasterResidentListNavbar);
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "MDS Master Resident List");
            VerifyElement.IsPresent(selectNeighborhoodDropdown);
            VerifyElement.IsPresent(createReportButton);

            //Bottom
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
            VerifyElement.IsPresent(developedByFooter);
        }
        #endregion
    }
}