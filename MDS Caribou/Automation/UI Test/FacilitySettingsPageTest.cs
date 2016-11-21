using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.UI_Test
{
    [TestFixture]
    class FacilitySettingsPageTestPageTest : BaseSetup
    {
        [Test]
        public void TC030_FacilitySettings_PageObjectVerificationPageTest()
        {
            Browser.Open();
            LoginPage.SignIn();
            LandingPage.NavigateToAdminPage();
            AdminPage.NavigateToFacilitySettings();
            Driver.WaitFor(2);
            VerifyElement.IsPresent(FacilitySettingsPage.homeIcon);
            VerifyElement.IsPresent(FacilitySettingsPage.caribouCLSSuiteNavbar);
            VerifyElement.IsPresent(FacilitySettingsPage.adminNavbar);
            VerifyElement.IsPresent(FacilitySettingsPage.facilitySettingsNavbar);
            VerifyElement.IsPresent(FacilitySettingsPage.notificationBellIcon);
            VerifyElement.IsPresent(FacilitySettingsPage.syncIcon);
            VerifyElement.IsPresent(FacilitySettingsPage.profileIcon);
            VerifyElement.AreEqual(FacilitySettingsPage.pageHeader, "Facility Settings");
            VerifyElement.AreEqual(FacilitySettingsPage.careAreasLabel, "Care Areas");
            VerifyElement.IsPresent(FacilitySettingsPage.useCareAreaAssessementsCheckBox);
            VerifyElement.AreEqual(FacilitySettingsPage.settingLabel, "Setting");
            VerifyElement.IsPresent(FacilitySettingsPage.urbanCheckBox);
            VerifyElement.IsPresent(FacilitySettingsPage.ruralCheckBox);
            VerifyElement.AreEqual(FacilitySettingsPage.facilityProviderNumbersLabel, "Facility Provider Numbers");
            VerifyElement.AreEqual(FacilitySettingsPage.npiLabel, "A. National Provider Identifier (NPI)");
            VerifyElement.IsPresent(FacilitySettingsPage.npiTextfield);
            VerifyElement.AreEqual(FacilitySettingsPage.ccnLabel, "B. CMS Certification Number (CCN)");
            VerifyElement.IsPresent(FacilitySettingsPage.ccnTextfield);
            VerifyElement.AreEqual(FacilitySettingsPage.spnLabel, "C. State Provider Number");
            VerifyElement.IsPresent(FacilitySettingsPage.spnTextfield);
            VerifyElement.AreEqual(FacilitySettingsPage.aitcLabel, "AITC");
            VerifyElement.AreEqual(FacilitySettingsPage.subIDLabel, "Assigned Facility/Provider Submission ID");
            VerifyElement.IsPresent(FacilitySettingsPage.subIDTextField);
            VerifyElement.AreEqual(FacilitySettingsPage.typeOfProviderLabel, "A0200. Type of Provider");
            VerifyElement.IsPresent(FacilitySettingsPage.nursingHomeCheckBox);
            VerifyElement.IsPresent(FacilitySettingsPage.swingBedCheckBox);
            VerifyElement.AreEqual(FacilitySettingsPage.submissionRequirementLabel, "A0410. Submission Requirement");
            VerifyElement.IsPresent(FacilitySettingsPage.option1CheckBox);
            VerifyElement.IsPresent(FacilitySettingsPage.option2CheckBox);
            VerifyElement.IsPresent(FacilitySettingsPage.option3CheckBox);
            VerifyElement.AreEqual(FacilitySettingsPage.assessmentSettingsLabel, "Assessment Settings");
            VerifyElement.AreEqual(FacilitySettingsPage.quarterlyAssessmentLabel, "Quarterly Assessment");
            VerifyElement.IsPresent(FacilitySettingsPage.quarterlyAssessmentScrollBar);
            VerifyElement.AreEqual(FacilitySettingsPage.annualAssessmentLabel, "Annual Assessment");
            VerifyElement.IsPresent(FacilitySettingsPage.annualAssessmentScrollBar);
            VerifyElement.IsPresent(FacilitySettingsPage.caribouCLSSuiteFooter);
            VerifyElement.IsPresent(FacilitySettingsPage.versionFooter);
            VerifyElement.IsPresent(FacilitySettingsPage.userFooter);
            VerifyElement.IsPresent(FacilitySettingsPage.developedByFooter);
        }

    }
}