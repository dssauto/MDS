using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class NursingIndexAndRUGIVReimbursementReportPageTest : BaseSetup
    {
        //[Test]
        public void TC038_NursingIndexAndRUGIVReimbersementReport_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            //LandingPage.NavigateToReportsFormsPage();
            //DashboardPage.NavigateToBilling();
            //DashboardPage.NavigateToReimbursemenet();
            Driver.Instance.Navigate().GoToUrl("http://cariboudevweb.dssinc.com/CaribouCLCSuite/menu/dashboard/rugiv");
            Driver.WaitFor(2);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.homeIcon);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.reportsFormsNavbar);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.nursingIndexAndRugIVReimbursementNavbar);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.notificationBellIcon);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.syncStatusIcon);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.profileIcon);
            VerifyElement.AreEqual(NursingIndexAndRUGIVReimbursementReportPage.pageHeader, "Nursing Index and RUG-IV Reimbursement Report");
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.selectDateFilter);
            Driver.ClickOn(NursingIndexAndRUGIVReimbursementReportPage.selectDateFilter);
            Driver.WaitFor(2);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.applyButton);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.cancelButton);
            Driver.ClickOn(NursingIndexAndRUGIVReimbursementReportPage.cancelButton);
            Driver.WaitFor(2);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.selectLocationDropdown);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.caribouCLSSuiteFooter);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.versionFooter);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.userFooter);
            VerifyElement.IsPresent(NursingIndexAndRUGIVReimbursementReportPage.developedByFooter);
        }
    }
}