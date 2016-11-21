using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class QualityMeasuresShortStayDetailsPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By reportsFormsTitle = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By qualityIndicatorsMeasuresShortTermTitle = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
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

        //MDS 3.0 Facility Level Quality Measure Report = Resident Details (Short Stay) 
        static internal By mdsShortStayTitle = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/h2");
        static internal By facilityIDLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[1]/td[1]");
        static internal By reportPeriodLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[1]/td[2]");
        static internal By facilityNameLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[2]/td[1]");
        static internal By runDateLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[2]/td[2]");
        static internal By cityStateLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[3]/td[1]");
        static internal By residentNameColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[1]/div/span");
        static internal By a0310ABFColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[2]/div/span");
        static internal By moderateToSeverePainColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[3]/div/span");
        static internal By pressureUlcersNewOrWorsenedColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[4]/div/span");
        static internal By givenSeasonalFluVaccColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[5]/div/span");
        static internal By receivedTheSeasonalFluVaccColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[6]");
        static internal By offeredAndDeclinedFluVaccColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[7]/div/span");
        static internal By didNotReceiveFluVaccContraindicatedColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[8]");
        static internal By assessedAppropriatelyGivenPneumoVaccColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[9]/div/span");
        static internal By receivedThePneumoVaccColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[10]/div/span");
        static internal By offeredAndDeclinedPneumoVaccColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[11]/div/span");
        static internal By didntReceivePneumoVacContraindicatedColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[12]/div/span");
        static internal By newlyReceivedAntipsychoticMedicationColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[13]/div/span");
        static internal By improvedTransferLocomotionAndWalkingColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[14]/div/span");
        static internal By qualityMeasureCountColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[15]/div/span");
        static internal By dataColumnLabel = By.XPath("//*[@id='divToPrint']/thead/tr[3]/th[1]");
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
            VerifyElement.AreEqual(reportsFormsTitle, "Reports & Forms");
            VerifyElement.AreEqual(qualityIndicatorsMeasuresShortTermTitle, "Quality Indicators & Measures - Short Term");
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "Quality Measures Short Stay Details");
            VerifyElement.IsPresent(selectDateFilter);
            Driver.ClickOn(selectDateFilter);
            VerifyElement.IsPresent(applyButton);
            VerifyElement.IsPresent(cancelButton);
            VerifyElement.IsPresent(printButton);
            VerifyElement.IsPresent(wordButton);
            VerifyElement.IsPresent(createReportButton);
            VerifyElement.AreEqual(mdsShortStayTitle, "MDS 3.0 Facility Level Quality Measure Report - Resident Detail (Short Stay)");
            VerifyElement.IsPresent(facilityIDLabel);
            VerifyElement.IsPresent(reportPeriodLabel);
            VerifyElement.IsPresent(facilityNameLabel);
            VerifyElement.IsPresent(runDateLabel);
            VerifyElement.IsPresent(cityStateLabel);
            VerifyElement.IsPresent(residentNameColumnLabel);
            VerifyElement.AreEqual(a0310ABFColumnLabel, "A0310A/B/F");
            VerifyElement.AreEqual(moderateToSeverePainColumnLabel, "Moderate to Severe Pain N001.01 (S)");
            VerifyElement.AreEqual(pressureUlcersNewOrWorsenedColumnLabel, "Pressure Ulcers New or Worsened N002.02(S)");
            VerifyElement.AreEqual(givenSeasonalFluVaccColumnLabel, "Given Seasonal FluVacc N003.02(S)");
            VerifyElement.AreEqual(receivedTheSeasonalFluVaccColumnLabel, "Received the Seasonal FluVacc N004.02(S)");
            VerifyElement.AreEqual(offeredAndDeclinedFluVaccColumnLabel, "Offered and Declined FluVacc N005.02(S)");
            VerifyElement.AreEqual(didNotReceiveFluVaccContraindicatedColumnLabel, "Did Not Receive FluVacc, Contraindicated N006.02(S)");
            VerifyElement.AreEqual(assessedAppropriatelyGivenPneumoVaccColumnLabel, "Assessed / Appropriately Given PneumoVacc N007.01(S)");
            VerifyElement.AreEqual(receivedThePneumoVaccColumnLabel, "Received the PneumoVacc N008.01(S)");
            VerifyElement.AreEqual(offeredAndDeclinedPneumoVaccColumnLabel, "Offered and Declined PneumoVacc N009.01 (S)");
            VerifyElement.AreEqual(didntReceivePneumoVacContraindicatedColumnLabel, "Didn’t Receive PneumoVac, Contraindicated N010.01(S)");
            VerifyElement.AreEqual(newlyReceivedAntipsychoticMedicationColumnLabel, "Newly Received Antipsychotic Medication N011.01(S)");
            VerifyElement.AreEqual(improvedTransferLocomotionAndWalkingColumnLabel, "Improved Transfer, Locomotion, and Walking N037.01(S)");
            VerifyElement.AreEqual(qualityMeasureCountColumnLabel, "Quality Measure Count");
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