using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class MDSAdhocPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By reportsFormsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By mdsAdhocNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/div/header/h1");
        static internal By createReportButton = By.XPath("//*[@id='main-content']/div/div/div/div[1]/div/div/div/div/button");

        //Generate Adhoc Report
        static internal By generateAdhocReportHeader = By.XPath("//*[@id='mds']/div[1]/div/div/div[1]/h3");
        static internal By templateTab = By.XPath("//*[@id='testWizard']/ul/li[1]");
        static internal By filterTab = By.XPath("//*[@id='testWizard']/ul/li[2]");
        static internal By searchTab = By.XPath("//*[@id='testWizard']/ul/li[3]");
        static internal By outputTab = By.XPath("//*[@id='testWizard']/ul/li[4]");
        static internal By prevButton = By.XPath("//*[@id='testWizard']/div[1]/button[1]");
        static internal By nextButton = By.XPath("//*[@id='testWizard']/div[1]/button[2]");
        static internal By selectSavedReportTemplateLabel = By.XPath("//*[@id='testWizard']/div[2]/div[1]/div/div[1]/label");
        static internal By selectSavedReportTemplateField = By.XPath("//*[@id='testWizard']/div[2]/div[1]/div/div[1]/div");
        static internal By orText = By.XPath("//*[@id='testWizard']/div[2]/div[1]/div/div[2]/h2");
        static internal By newReportNameLabel = By.XPath("//*[@id='testWizard']/div[2]/div[1]/div/div[3]/div/label");
        static internal By newreportNameField = By.Id("reportName");
        static internal By closeButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/div[1]/div[2]/button[1]");
        static internal By saveTemplateButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/div[1]/div[2]/button[2]");
        static internal By runReportButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/div[1]/div[2]/button[3]");

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
            VerifyElement.IsPresent(reportsFormsNavbar);
            VerifyElement.IsPresent(mdsAdhocNavbar);
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "MDS Ad-hoc Reports");
            VerifyElement.IsPresent(createReportButton);

            //Generate Adhoc Report
            VerifyElement.AreEqual(generateAdhocReportHeader, "Generate Addhoc Report");
            VerifyElement.IsPresent(templateTab);
            VerifyElement.IsPresent(filterTab);
            VerifyElement.IsPresent(searchTab);
            VerifyElement.IsPresent(outputTab);
            VerifyElement.IsPresent(prevButton);
            VerifyElement.IsPresent(nextButton);
            VerifyElement.AreEqual(selectSavedReportTemplateLabel, "Select Saved Report Template:");
            VerifyElement.IsPresent(selectSavedReportTemplateField);
            VerifyElement.IsPresent(orText);
            VerifyElement.AreEqual(newReportNameLabel, "New Report Name:");
            VerifyElement.IsPresent(newreportNameField);
            VerifyElement.IsPresent(closeButton);
            VerifyElement.IsPresent(saveTemplateButton);
            VerifyElement.IsPresent(runReportButton);

            //Bottom
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
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