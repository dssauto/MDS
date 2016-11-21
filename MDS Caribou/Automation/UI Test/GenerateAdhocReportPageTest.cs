using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class GenerateAdhocReportPageTest : BaseSetup
    {
        [Test]
        public void TC031_GenerateAdhocReport_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToReportsFormsPage();
            DashboardPage.NavigateToMDSAdHocReports();
            Driver.WaitFor(2);
            Driver.ClickOn(MDSAdhocPage.createReportButton);
            Driver.WaitFor(2);
            VerifyElement.AreEqual(MDSAdhocPage.generateAdhocReportHeader, "Generate Adhoc Report");
            VerifyElement.IsPresent(MDSAdhocPage.templateTab);
            VerifyElement.IsPresent(MDSAdhocPage.filterTab);
            VerifyElement.IsPresent(MDSAdhocPage.searchTab);
            VerifyElement.IsPresent(MDSAdhocPage.outputTab);
            VerifyElement.IsPresent(MDSAdhocPage.prevButton);
            VerifyElement.IsPresent(MDSAdhocPage.nextButton);
            VerifyElement.AreEqual(MDSAdhocPage.selectSavedReportTemplateLabel, "Select Saved Report Template:");
            VerifyElement.IsPresent(MDSAdhocPage.selectSavedReportTemplateField);
            VerifyElement.AreEqual(MDSAdhocPage.orText, "OR");
            VerifyElement.AreEqual(MDSAdhocPage.newReportNameLabel, "New Report Name:");
            VerifyElement.IsPresent(MDSAdhocPage.newreportNameField);
            VerifyElement.IsPresent(MDSAdhocPage.closeButton);
            VerifyElement.IsPresent(MDSAdhocPage.saveTemplateButton);
            VerifyElement.IsPresent(MDSAdhocPage.runReportButton);
        }

    }
}
