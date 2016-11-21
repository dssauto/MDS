using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class WorkInProgressPageTest : BaseSetup
    {
        [Test]
        public void TC047_WorkInProgress_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToWorkInProgressPage();
            VerifyElement.IsPresent(WorkInProgressPage.homeIcon);
            VerifyElement.IsPresent(WorkInProgressPage.caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(WorkInProgressPage.workInProgressIcon);
            VerifyElement.IsPresent(WorkInProgressPage.workInProgressNavbar);
            VerifyElement.IsPresent(WorkInProgressPage.notificationBellIcon);
            VerifyElement.IsPresent(WorkInProgressPage.syncStatusIcon);
            VerifyElement.IsPresent(WorkInProgressPage.profileIcon);
            VerifyElement.AreEqual(WorkInProgressPage.pageHeader, "Work In Progress");
            VerifyElement.IsPresent(WorkInProgressPage.obraFilterButtonChecked);
            VerifyElement.IsPresent(WorkInProgressPage.ppsFilterButtonChecked);
            VerifyElement.IsPresent(WorkInProgressPage.sliderBar);
            VerifyElement.IsPresent(WorkInProgressPage.lastNameSearchTextField);
            VerifyElement.IsPresent(WorkInProgressPage.selectLocationDropdown);
            VerifyElement.AreEqual(WorkInProgressPage.residentColumnLabel, "Resident");
            VerifyElement.AreEqual(WorkInProgressPage.admitDischargeColumnLabel, "Admit\r\nDischarge");
            VerifyElement.AreEqual(WorkInProgressPage.assessmentTypeColumnLabel, "Assessment Type");
            VerifyElement.AreEqual(WorkInProgressPage.ardColumnLabel, "ARD");
            VerifyElement.AreEqual(WorkInProgressPage.rnVerifyColumnLabel, "RN Verify");
            VerifyElement.AreEqual(WorkInProgressPage.completeByDateColumnLabel, "Complete By Date (Z0500B)");
            VerifyElement.AreEqual(WorkInProgressPage.caaCompleteByColumnLabel, "CAA Complete By (V0200B2)");
            VerifyElement.AreEqual(WorkInProgressPage.carePlanReviewColumnLabel, "Care Plan Review");
            VerifyElement.IsPresent(WorkInProgressPage.refreshButton);

            //Residents Tiles
            //OPEN WIP button for each residents
            //Number of page on the list
            //Number of Assessments in the lower right corner

            VerifyElement.IsPresent(WorkInProgressPage.previousButton);
            VerifyElement.IsPresent(WorkInProgressPage.nextButton);
            VerifyElement.IsPresent(WorkInProgressPage.caribouCLSSuiteFooter);
            VerifyElement.IsPresent(WorkInProgressPage.versionFooter);
            VerifyElement.IsPresent(WorkInProgressPage.userFooter);
            VerifyElement.IsPresent(WorkInProgressPage.developedByFooter);
        }
    }
}