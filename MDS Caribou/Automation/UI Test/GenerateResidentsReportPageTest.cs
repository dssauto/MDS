using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.UI_Test
{
    [TestFixture]
    class GenerateResidentsReportPageTest : BaseSetup
    {
        [Test]
        public void TC032_GenerateResidentsReport_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToReportsFormsPage();
            DashboardPage.NavigateToMDSMasterResidentList();
            Driver.WaitFor(2);
            Driver.ClickOn(MDSMasterResidentListPage.createReportButton);
            Driver.WaitFor(2);
            VerifyElement.AreEqual(GenerateResidentsReportPage.generateResidentsReportHeader, "Generate Residents Report");
            VerifyElement.IsPresent(GenerateResidentsReportPage.selectLocationDropdown);
            VerifyElement.IsPresent(GenerateResidentsReportPage.cancelButton);
            VerifyElement.IsPresent(GenerateResidentsReportPage.confirmButton);
            }
        }
}