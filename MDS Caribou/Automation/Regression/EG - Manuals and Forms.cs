using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class EG___Manuals_and_Forms : BaseSetup
    {
        [Test]
        public void EG_Manuals_and_Forms()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Reports & Forms Tile.
            LandingPage.NavigateToReportsFormsPage();
            //Step 2  Click the Manuals and Forms options from the left hand navigation menu.
            DashboardPage.NavigateToManualsAndForms();
            //Step 3  Select ALL of the links in the Manuals and forms page and verify that the links are directed to their appropriate title description.
            VerifyElement.AreEqual(ManualsAndFormsPage.userManualLink, "User's Manual");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomeComprehensiveLink, "Nursing Home Comprehensive (NC) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomeDischargeLink, "Nursing Home Discharge (ND) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomeAndSwingBedOMRANoSoLink, "Nursing Home and Swing Bed OMRA (NO/SO) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomeAndSwingBedOMRALink, "Nursing Home OMRA-Discharge (NOD) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomePPSLink, "Nursing Home PPS (NP) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomeQuarterlyLink, "Nursing Home Quarterly (NQ) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomeAndSwingBedLink, "Nursing Home and Swing Bed OMRA-Start of Therapy (NS/SS) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomeOMRAStartOfTherapyAndDischargeLink, "Nursing Home OMRA-Start of Therapy and Discharge (NSD) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomeAndSwingBedTrackingLink, "Nursing Home and Swing Bed Tracking (NT/ST) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.swingBedDischargeLink, "Swing Bed Discharge (SD) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomeAndSwingBedOMRANoSoLink, "Nursing Home and Swing Bed OMRA (NO/SO) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.swingBedOMRADischargeLink, "Swing Bed OMRA-Discharge (SOD) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.swingBedPPSLink, "Swing Bed PPS (SP) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomeAndSwingBedOMRAStartOfTherapyLink, "Nursing Home and Swing Bed OMRA-Start of Therapy (NS/SS) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.swingBedOMRAStartOfTherapyAndDischargeLink, "Swing Bed OMRA-Start of Therapy and Discharge (SSD) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.nursingHomeAndSwingBedTrackingLink, "Nursing Home and Swing Bed Tracking (NT/ST) Item Set");
            VerifyElement.AreEqual(ManualsAndFormsPage.deliriumLink, "1. Delirium");
            VerifyElement.AreEqual(ManualsAndFormsPage.cognitiveLossDementiaLink, "2. Cognitive Loss/Dementia");
            VerifyElement.AreEqual(ManualsAndFormsPage.visualFunctionLink, "3. Visual Function");
            VerifyElement.AreEqual(ManualsAndFormsPage.communicationLink, "4. Communication");
            VerifyElement.AreEqual(ManualsAndFormsPage.activitesOfDailyLivingLink, "5. Activities of Daily Living (ADLs) - Functional Status/Rehabilitation Potential");
            VerifyElement.AreEqual(ManualsAndFormsPage.urinaryIncontitenceAndIndwellingCatheterLink, "6. Urinary Incontinence and Indwelling Catheter");
            VerifyElement.AreEqual(ManualsAndFormsPage.psychosocialWellBeingLink, "7. Psychosocial Well-Being");
            VerifyElement.AreEqual(ManualsAndFormsPage.moodStateLink, "8. Mood State");
            VerifyElement.AreEqual(ManualsAndFormsPage.behavioralSymptomsLink, "9. Behavioral Symptoms");
            VerifyElement.AreEqual(ManualsAndFormsPage.activitesLink, "10. Activities");
            VerifyElement.AreEqual(ManualsAndFormsPage.fallLink, "11. Fall(s)");
            VerifyElement.AreEqual(ManualsAndFormsPage.nutritionalStatusLink, "12. Nutritional Status");
            VerifyElement.AreEqual(ManualsAndFormsPage.feedingTubeLink, "13. Feeding Tube(s)");
            VerifyElement.AreEqual(ManualsAndFormsPage.dehydrationFluidMaintanceLink, "14. Dehydration/Fluid Maintenance");
            VerifyElement.AreEqual(ManualsAndFormsPage.dentalCareLink, "15. Dental Care");
            VerifyElement.AreEqual(ManualsAndFormsPage.pressureUlcerLink, "16. Pressure Ulcer(s)");
            VerifyElement.AreEqual(ManualsAndFormsPage.psychotropicMedicationUseLink, "17. Psychotropic Medication Use");
            VerifyElement.AreEqual(ManualsAndFormsPage.physicalRestraintsLink, "18. Physical Restraints");
            VerifyElement.AreEqual(ManualsAndFormsPage.painLink, "19. Pain");
            VerifyElement.AreEqual(ManualsAndFormsPage.returnToCommunityReferralLink, "20. Return to Community Referral");
        }

    }
}
