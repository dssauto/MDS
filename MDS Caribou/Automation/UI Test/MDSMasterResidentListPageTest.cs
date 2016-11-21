using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class MDSMasterResidentListPageTest : BaseSetup
    {
        [Test]
        public void TC035_MDSMasterResidentList_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToReportsFormsPage();
            Driver.WaitFor(1);
            DashboardPage.NavigateToMDSMasterResidentList();
            Driver.WaitFor(1);
            VerifyElement.IsPresent(MDSMasterResidentListPage.homeIcon);
            VerifyElement.IsPresent(MDSMasterResidentListPage.caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(MDSMasterResidentListPage.reportsFormsNavbar);
            VerifyElement.IsPresent(MDSMasterResidentListPage.mdsMasterResidentListNavbar);
            VerifyElement.IsPresent(MDSMasterResidentListPage.notificationBellIcon);
            VerifyElement.IsPresent(MDSMasterResidentListPage.syncStatusIcon);
            VerifyElement.IsPresent(MDSMasterResidentListPage.profileIcon);
            VerifyElement.AreEqual(MDSMasterResidentListPage.pageHeader, "MDS Master Resident List");
            VerifyElement.IsPresent(MDSMasterResidentListPage.selectNeighborhoodDropdown);
            VerifyElement.IsPresent(MDSMasterResidentListPage.createReportButton);
            VerifyElement.IsPresent(MDSMasterResidentListPage.caribouCLSSuiteFooter);
            VerifyElement.IsPresent(MDSMasterResidentListPage.versionFooter);
            VerifyElement.IsPresent(MDSMasterResidentListPage.userFooter);
            VerifyElement.IsPresent(MDSMasterResidentListPage.developedByFooter);
        }
    }
}