using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class QMFacilityCharacteristicsPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By reportsFormsTitle = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By qualityIndicatorsMeasuresFacilityCharacteristicsTitle = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/div/header/h1");
        static internal By selectDateFilter = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[1]/div/div/input");
        static internal By applyButton = By.XPath("//*[@id='mds']/div[4]/div[3]/div/button[1]");
        static internal By cancelButton = By.XPath("//*[@id='mds']/div[4]/div[3]/div/button[2]");
        static internal By printButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[2]/button[1]");
        static internal By wordButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[2]/button[2]");
        static internal By createReportButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[3]/button");

        //MDS 3.0 Facility Characteristrics Report
        static internal By mdsFacilityCharacteristicsReportTitle = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/h2");
        static internal By facilityIDLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[1]/td[1]");
        static internal By reportPeriodLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[1]/td[2]");
        static internal By facilityNameLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[2]/td[1]");
        static internal By runDateLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[2]/td[2]");
        static internal By cityStateLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[3]/td[1]");
        static internal By numLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[2]");
        static internal By denomLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[3]");
        static internal By measurePercentLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[4]");

        //Gender
        static internal By genderLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[1]/td/span");
        static internal By maleColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[1]/td/table/tbody/tr[1]/td[1]");
        static internal By femaleColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[1]/td/table/tbody/tr[2]/td[1]");

        //Age
        static internal By ageLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[2]/td/span");
        static internal By twentyFiveColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[2]/td/table/tbody/tr[1]/td[1]");
        static internal By twentyFiveToFiftyFourColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[2]/td/table/tbody/tr[2]/td[1]");
        static internal By fiftyFiveToSixtyFourColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[2]/td/table/tbody/tr[3]/td[1]");
        static internal By sixtyFiveToSeventyFourColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[2]/td/table/tbody/tr[4]/td[1]");
        static internal By seventyFiveToEightyFourColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[2]/td/table/tbody/tr[5]/td[1]");
        static internal By eightyFivePlusColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[2]/td/table/tbody/tr[6]/td[1]");

        //Diagnostic Characteristics
        static internal By diagnosticCharacteristicsLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[3]/td/span");
        static internal By psychiatricDiagnosisColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[3]/td/table/tbody/tr[1]/td[1]");
        static internal By intellectualOrDevelopmentalDisabilityColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[3]/td/table/tbody/tr[2]/td[1]");
        static internal By dcHospiceColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[3]/td/table/tbody/tr[3]/td[1]");

        //Prognosis
        static internal By prognosisLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[4]/td/span");
        static internal By lifeExpectancyLessThan6MonthsColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[4]/td/table/tbody/tr/td[1]");

        //Discharge Plan
        static internal By dischargePlanLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[5]/td/span");
        static internal By notAlreadyOccuringColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[5]/td/table/tbody/tr[1]/td[1]");
        static internal By alreadyOccuringColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[5]/td/table/tbody/tr[2]/td[1]");

        //Referral
        static internal By referralLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[6]/td/span");
        static internal By notNeededColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[6]/td/table/tbody/tr[1]/td[1]");
        static internal By isOrMayBeNeededButNotYetMadeColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[6]/td/table/tbody/tr[2]/td[1]");
        static internal By hasBeenMadeColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[6]/td/table/tbody/tr[3]/td[1]");

        //Type of Entry
        static internal By typeofEntryLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[7]/td/span");
        static internal By admissionColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[7]/td/table/tbody/tr[1]/td[1]");
        static internal By reentryColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[7]/td/table/tbody/tr[2]/td[1]");

        //Entered Facility From
        static internal By enteredFacilityFromLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[8]/td/span");
        static internal By communityColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[8]/td/table/tbody/tr[1]/td[1]");
        static internal By anotherNursingHomeColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[8]/td/table/tbody/tr[2]/td[1]");
        static internal By acuteHospitalColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[8]/td/table/tbody/tr[3]/td[1]");
        static internal By psychiatricHospitalColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[8]/td/table/tbody/tr[4]/td[1]");
        static internal By impatientRehabilitationFacilityColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[8]/td/table/tbody/tr[5]/td[1]");
        static internal By idddFacilityColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[8]/td/table/tbody/tr[6]/td[1]");
        static internal By effHospiceColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[8]/td/table/tbody/tr[7]/td[1]");
        static internal By longTermCareHospitalColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[8]/td/table/tbody/tr[8]/td[1]");
        static internal By otherColumnLabel = By.XPath("//*[@id='divToPrint']/tbody/tr[8]/td/table/tbody/tr[9]/td[1]");

        static internal By privacyProtectedDataMessage = By.XPath("//*[@id='divToPrint']/tbody/tr[9]/td/h3");

        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.IsPresent(homeIcon);
            VerifyElement.TitleIsPresent("Caribou CLC Suite");
            VerifyElement.IsPresent(reportsFormsTitle);
            VerifyElement.IsPresent(qualityIndicatorsMeasuresFacilityCharacteristicsTitle);
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "QM Facility Characteristics");
            VerifyElement.IsPresent(selectDateFilter);
            Driver.ClickOn(selectDateFilter);
            VerifyElement.IsPresent(applyButton);
            VerifyElement.IsPresent(cancelButton);
            VerifyElement.IsPresent(printButton);
            VerifyElement.IsPresent(wordButton);
            VerifyElement.IsPresent(createReportButton);
            VerifyElement.AreEqual(mdsFacilityCharacteristicsReportTitle, "MDS 3.0 Facility Characteristics Report");
            VerifyElement.IsPresent(facilityIDLabel);
            VerifyElement.IsPresent(reportPeriodLabel);
            VerifyElement.IsPresent(facilityNameLabel);
            VerifyElement.IsPresent(runDateLabel);
            VerifyElement.IsPresent(cityStateLabel);
            VerifyElement.IsPresent(numLabel);
            VerifyElement.IsPresent(denomLabel);
            VerifyElement.IsPresent(measurePercentLabel);
            VerifyElement.IsPresent(genderLabel);
            VerifyElement.IsPresent(maleColumnLabel);
            VerifyElement.IsPresent(femaleColumnLabel);
            VerifyElement.IsPresent(ageLabel);
            VerifyElement.IsPresent(twentyFiveColumnLabel);
            VerifyElement.IsPresent(twentyFiveToFiftyFourColumnLabel);
            VerifyElement.IsPresent(fiftyFiveToSixtyFourColumnLabel);
            VerifyElement.IsPresent(sixtyFiveToSeventyFourColumnLabel);
            VerifyElement.IsPresent(eightyFivePlusColumnLabel);
            VerifyElement.IsPresent(diagnosticCharacteristicsLabel);
            VerifyElement.IsPresent(psychiatricDiagnosisColumnLabel);
            VerifyElement.IsPresent(intellectualOrDevelopmentalDisabilityColumnLabel);
            VerifyElement.IsPresent(dcHospiceColumnLabel);
            VerifyElement.IsPresent(prognosisLabel);
            VerifyElement.IsPresent(lifeExpectancyLessThan6MonthsColumnLabel);
            VerifyElement.IsPresent(dischargePlanLabel);
            VerifyElement.IsPresent(notAlreadyOccuringColumnLabel);
            VerifyElement.IsPresent(alreadyOccuringColumnLabel);
            VerifyElement.IsPresent(referralLabel);
            VerifyElement.IsPresent(notNeededColumnLabel);
            VerifyElement.IsPresent(isOrMayBeNeededButNotYetMadeColumnLabel);
            VerifyElement.IsPresent(hasBeenMadeColumnLabel);
            VerifyElement.IsPresent(typeofEntryLabel);
            VerifyElement.IsPresent(admissionColumnLabel);
            VerifyElement.IsPresent(reentryColumnLabel);
            VerifyElement.IsPresent(enteredFacilityFromLabel);
            VerifyElement.IsPresent(communityColumnLabel);
            VerifyElement.IsPresent(anotherNursingHomeColumnLabel);
            VerifyElement.IsPresent(acuteHospitalColumnLabel);
            VerifyElement.IsPresent(psychiatricHospitalColumnLabel);
            VerifyElement.IsPresent(impatientRehabilitationFacilityColumnLabel);
            VerifyElement.IsPresent(idddFacilityColumnLabel);
            VerifyElement.IsPresent(longTermCareHospitalColumnLabel);
            VerifyElement.IsPresent(otherColumnLabel);
            VerifyElement.AreEqual(privacyProtectedDataMessage, "This report may contain privacy protected data and should not be released to public");
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.AreEqual(versionFooter, "v2.1.1.49");
            VerifyElement.AreEqual(userFooter, "Selenium, Facility");
            VerifyElement.IsPresent(developedByFooter);

        }

        #endregion

        #region Navigation

        public static void NavigateTo()
        {
        }
        #endregion

    }
}