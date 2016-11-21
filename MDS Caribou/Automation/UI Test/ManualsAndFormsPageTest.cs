using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class ManualsAndFormsPageTest : BaseSetup
    {
        [Test]
        public void TC033_ManualsAndForms_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToReportsFormsPage();
            DashboardPage.NavigateToManualsAndForms();
            Driver.WaitFor(2);
            VerifyElement.IsPresent(ManualsAndFormsPage.homeIcon);
            VerifyElement.IsPresent(ManualsAndFormsPage.caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(ManualsAndFormsPage.reportsFormsNavbar);
            VerifyElement.IsPresent(ManualsAndFormsPage.notificationBellIcon);
            VerifyElement.IsPresent(ManualsAndFormsPage.syncStatusIcon);
            VerifyElement.IsPresent(ManualsAndFormsPage.profileIcon);
            VerifyElement.AreEqual(ManualsAndFormsPage.pageHeader, "Manuals and Forms");
            VerifyElement.IsPresent(ManualsAndFormsPage.mdsRAIManualsLabel);
            VerifyElement.IsPresent(ManualsAndFormsPage.userManualLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.mdsFormsLabel);
            VerifyElement.AreEqual(ManualsAndFormsPage.longTermLabel, "Long Term");
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomeComprehensiveLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomeDischargeLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomeAndSwingBedOMRALink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomeAndSwindBedOMRALink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomeOMRADischargeLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomePPSLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomeQuarterlyLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomeAndSwingBedOMRAStartOfTherapyLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomeOMRAStartOfTherapyAndDischargeLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomeAndSwingBedTrackingLink);
            VerifyElement.AreEqual(ManualsAndFormsPage.swingBedLabel, "Swing Bed");
            VerifyElement.IsPresent(ManualsAndFormsPage.swingBedDischargeLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomeAndSwingBedOMRALink);
            VerifyElement.IsPresent(ManualsAndFormsPage.swingBedPPSLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nursingHomeAndSwingBedOMRAStartOfTherapyLink);
            VerifyElement.AreEqual(ManualsAndFormsPage.caas2015Label, "CAAs 2015");
            VerifyElement.IsPresent(ManualsAndFormsPage.deliriumLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.cognitiveLossDementiaLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.visualFunctionLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.communicationLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.activitesOfDailyLivingLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.urinaryIncontitenceAndIndwellingCatheterLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.psychosocialWellBeingLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.moodStateLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.behavioralSymptomsLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.activitesLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.fallLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.nutritionalStatusLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.feedingTubeLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.dehydrationFluidMaintanceLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.dentalCareLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.pressureUlcerLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.psychotropicMedicationUseLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.physicalRestraintsLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.painLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.returnToCommunityReferralLink);
            VerifyElement.IsPresent(ManualsAndFormsPage.caribouCLSSuiteFooter);
            VerifyElement.IsPresent(ManualsAndFormsPage.versionFooter);
            VerifyElement.IsPresent(ManualsAndFormsPage.userFooter);
            VerifyElement.IsPresent(ManualsAndFormsPage.developedByFooter);

        }
    }
}