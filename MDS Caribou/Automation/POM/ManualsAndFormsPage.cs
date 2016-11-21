using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class ManualsAndFormsPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By caribouCLSSuiteNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a");
        static internal By reportsFormsIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a/i");
        static internal By reportsFormsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By manualsFormsIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span/i");
        static internal By manualsFormsNavbar = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/div/div/header/h1");

        //MDS 3.0 RAI Manuals V1.13
        static internal By mdsRAIManualsLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div[1]/div/h3");
        static internal By userManualLink = By.XPath("//a[@href='https://www.cms.gov/Medicare/Quality-Initiatives-Patient-Assessment-Instruments/NursingHomeQualityInits/Downloads/MDS-30-RAI-Manual-V113.pdf']");

        //MDS Forms (Item Sets) V1.13.2 Effective 10/01/2015
        //Long Term
        static internal By mdsFormsLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div[2]/div/h3");
        static internal By longTermLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div[2]/div/h4[1]/b");
        static internal By nursingHomeComprehensiveLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Long Term/NC - Comprehensive MDS v1.13.2.pdf']");
        static internal By nursingHomeDischargeLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Long Term/ND - Discharge MDS v1.13.2.pdf']");
        static internal By nursingHomeAndSwingBedLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Long Term/NS - OMRA-SOT MDS v1.13.2.pdf']");
        static internal By nursingHomeOMRADischargeLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Long Term/NOD - OMRA-Discharge MDS v1.13.2.pdf']");
        static internal By nursingHomePPSLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Long Term/NP - PPS MDS v1.13.2.pdf']");
        static internal By nursingHomeQuarterlyLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Long Term/NQ - Quarterly MDS v1.13.2.pdf']");
        static internal By nursingHomeAndSwingBedOMRAStartOfTherapyLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Long Term/NS - OMRA-SOT MDS v1.13.2.pdf']");
        static internal By nursingHomeOMRAStartOfTherapyAndDischargeLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Long Term/NSD - OMRA-SOT and Discharge MDS v1.13.2.pdf']");
        static internal By nursingHomeAndSiwtchBedTrackingLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Long Term/NT - Entry and Death in Facility Tracking MDS v1.13.2.pdf']");

        //Swing Bed
        static internal By swingBedLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div[2]/div/h4[11]/b");
        static internal By swingBedDischargeLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Swing Bed/SD - Discharge MDS v1.13.2.pdf']");
        static internal By nursingHomeAndSwindBedOMRALink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Swing Bed/SO - OMRA MDS v1.13.2.pdf']");
        static internal By swingBedOMRADischargeLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Swing Bed/SOD - OMRA-Discharge MDS v1.13.2.pdf']");
        static internal By swingBedPPSLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Swing Bed/SP - PPS MDS v1.13.2.pdf']");
        static internal By nursingHomeAndSwingBedOMRALink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Long Term/NOD - OMRA-Discharge MDS v1.13.2.pdf']");
        static internal By nursingHomeAndSwingBedOMRANoSoLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Long Term/NO - OMRA MDS v1.13.2.pdf']");
        static internal By swingBedOMRAStartOfTherapyAndDischargeLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Swing Bed/SSD - OMRA-SOT and Discharge MDS v1.13.2.pdf']");
        static internal By nursingHomeAndSwingBedTrackingLink = By.XPath("//a[@href='./content/manual/v1.13/Item Sets/Swing Bed/ST - Entry and Death in Facility Tracking MDS v1.13.2.pdf']");

        //CAAs 2015
        static internal By caas2015Label = By.XPath("//*[@id='main-content']/div/div/div/div/div[3]/div/h3");
        static internal By deliriumLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Delirium.pdf']");
        static internal By cognitiveLossDementiaLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Dementia.pdf']");
        static internal By visualFunctionLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Visual.pdf']");
        static internal By communicationLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Communication.pdf']");
        static internal By activitesOfDailyLivingLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-ADLs.pdf']");
        static internal By urinaryIncontitenceAndIndwellingCatheterLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Urinary.pdf']");
        static internal By psychosocialWellBeingLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Psychosocial.pdf']");
        static internal By moodStateLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Mood.pdf']");
        static internal By behavioralSymptomsLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Behavioral.pdf']");
        static internal By activitesLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Activities.pdf']");
        static internal By fallLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Falls.pdf']");
        static internal By nutritionalStatusLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Nutrition.pdf']");
        static internal By feedingTubeLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Feeding.pdf']");
        static internal By dehydrationFluidMaintanceLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Dehydration.pdf']");
        static internal By dentalCareLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Dental.pdf']");
        static internal By pressureUlcerLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Pressure Ulcers.pdf']");
        static internal By psychotropicMedicationUseLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Psychotropic.pdf']");
        static internal By physicalRestraintsLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Restraints.pdf']");
        static internal By painLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Pain.pdf']");
        static internal By returnToCommunityReferralLink = By.XPath("//a[@href='./content/manual/v1.13/CAAs/CAA-Return.pdf']");

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
            VerifyElement.IsPresent(reportsFormsIcon);
            VerifyElement.IsPresent(reportsFormsNavbar);
            VerifyElement.IsPresent(manualsFormsIcon);
            VerifyElement.IsPresent(manualsFormsNavbar);
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "Manuals and Forms");

            //MDS 3.0 RAI Manuals V1.13
            VerifyElement.IsPresent(mdsRAIManualsLabel);
            VerifyElement.AreEqual(userManualLink, "User's Manual");

            //MDS Forms (Item Sets) V1.13.2 Effective 10/01/2015
            //Long Term
            VerifyElement.IsPresent(mdsFormsLabel);
            VerifyElement.AreEqual(longTermLabel, "Long Term");
            VerifyElement.AreEqual(nursingHomeComprehensiveLink, "Nursing Home Comprehensive (NC) Item Set");
            VerifyElement.AreEqual(nursingHomeDischargeLink, "Nursing Home Discharge (ND) Item Set");
            VerifyElement.AreEqual(nursingHomeAndSwindBedOMRALink, "Nursing Home and Swing Bed OMRA (NO/SO) Item Set");
            VerifyElement.AreEqual(nursingHomeOMRADischargeLink, "Nursing Home OMRA-Discharge (NOD) Item Set");
            VerifyElement.AreEqual(nursingHomePPSLink, "Nursing Home PPS (NP) Item Set");
            VerifyElement.AreEqual(nursingHomeQuarterlyLink, "Nursing Home Quarterly (NQ) Item Set");
            VerifyElement.AreEqual(nursingHomeAndSwingBedOMRAStartOfTherapyLink, "Nursing Home and Swing Bed OMRA-Start of Therapy (NS/SS) Item Set");
            VerifyElement.AreEqual(nursingHomeOMRAStartOfTherapyAndDischargeLink, "Nursing Home OMRA-Start of Therapy and Discharge (NDS) Item Set");
            VerifyElement.AreEqual(nursingHomeAndSwingBedTrackingLink, "Nursing Home and Swing Bed Tracking (NT/ST) Item Set");

            //Swing Bed
            VerifyElement.AreEqual(swingBedLabel, "Swing Bed");
            VerifyElement.AreEqual(swingBedDischargeLink, "Swing Bed Discharge (SD) Item Set");
            VerifyElement.AreEqual(nursingHomeAndSwindBedOMRALink, "Nursing Home and Swing Bed OMRA (NO/SO) Item Set");
            VerifyElement.AreEqual(swingBedOMRADischargeLink, "Swing Bed OMRA-Discharge (SOD) Item Set");
            VerifyElement.AreEqual(swingBedPPSLink, "Swing Bed PPS (SP)");
            VerifyElement.AreEqual(nursingHomeAndSwindBedOMRALink, "Nursing Home and Swing Bed OMRA-Start of Therapy (NS/SS) Item Set");
            VerifyElement.AreEqual(swingBedOMRADischargeLink, "Swing Bed OMRA-Start of Therapy and Discharge (SSD) Item Set");
            VerifyElement.AreEqual(nursingHomeAndSwingBedTrackingLink, "Nursing Home and Swing Bed Tracking (NT/ST) Item Set");

            //CAAs 2015
            VerifyElement.AreEqual(caas2015Label, "CAAs 2015");
            VerifyElement.AreEqual(deliriumLink, "1. Delirium");
            VerifyElement.AreEqual(cognitiveLossDementiaLink, "2. Cognitive Loss/Dementia");
            VerifyElement.AreEqual(visualFunctionLink, "3. Visual Function");
            VerifyElement.AreEqual(communicationLink, "4. Communication");
            VerifyElement.AreEqual(activitesOfDailyLivingLink, "5. Activities of Daily Living (ADLs) - Functional Status/Rehabilitation Potential");
            VerifyElement.AreEqual(urinaryIncontitenceAndIndwellingCatheterLink, "6. Urinary Incontinence and Indwelling Catheter");
            VerifyElement.AreEqual(psychosocialWellBeingLink, "7. Psychosocial Well-Being");
            VerifyElement.AreEqual(moodStateLink, "8. Mood State");
            VerifyElement.AreEqual(behavioralSymptomsLink, "9. Behavioral Symptoms");
            VerifyElement.AreEqual(activitesLink, "10. Activities");
            VerifyElement.AreEqual(fallLink, "11. Fall(s))");
            VerifyElement.AreEqual(nutritionalStatusLink, "12. Nutritional Status");
            VerifyElement.AreEqual(feedingTubeLink, "13. Feeding Tube(s)");
            VerifyElement.AreEqual(dehydrationFluidMaintanceLink, "14. Dehydration/Fluid Maintenance");
            VerifyElement.AreEqual(dentalCareLink, "15. Dental Care");
            VerifyElement.AreEqual(pressureUlcerLink, "16. Pressure Ulcer(s)");
            VerifyElement.AreEqual(psychotropicMedicationUseLink, "17. Psychotropic Medication Use");
            VerifyElement.AreEqual(physicalRestraintsLink, "18. Physical Restraints");
            VerifyElement.AreEqual(painLink, "19. Pain");
            VerifyElement.AreEqual(returnToCommunityReferralLink, "20. Return to Community Referral");

            //Bottom
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
            VerifyElement.IsPresent(developedByFooter);
        }
        #endregion

        #region Navigation
        public static void NavigateToUserManual()
        {
            Driver.ClickOn(userManualLink);
            VerifyElement.TitleIsPresent("CMS RAI Version 3.0 Manual v1.13_October 2015 - MDS-30-RAI-Manual-V113.pdf");
        }

        #endregion
    }
}