using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class MDSAdhocReportsPageTest : BaseSetup
    {
        [Test]
        public void TC034_MDSAdhocReports_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToReportsFormsPage();
            DashboardPage.NavigateToMDSAdhocReports();
            Driver.WaitFor(1);
            VerifyElement.IsPresent(MDSAdhocPage.homeIcon);
            VerifyElement.IsPresent(MDSAdhocPage.caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(MDSAdhocPage.reportsFormsNavbar);
            VerifyElement.IsPresent(MDSAdhocPage.notificationBellIcon);
            VerifyElement.IsPresent(MDSAdhocPage.syncStatusIcon);
            VerifyElement.IsPresent(MDSAdhocPage.profileIcon);
            VerifyElement.AreEqual(MDSAdhocPage.pageHeader, "MDS Ad-hoc Reports");
            VerifyElement.IsPresent(MDSAdhocPage.createReportButton);
            VerifyElement.IsPresent(ManualsAndFormsPage.caribouCLSSuiteFooter);
            VerifyElement.IsPresent(ManualsAndFormsPage.versionFooter);
            VerifyElement.IsPresent(ManualsAndFormsPage.userFooter);
            VerifyElement.IsPresent(ManualsAndFormsPage.developedByFooter);
        }
    }
}