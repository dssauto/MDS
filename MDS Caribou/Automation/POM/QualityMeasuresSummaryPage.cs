using Framework.POM;
using OpenQA.Selenium;

namespace Automation.POM
{
    class QualityMeasuresSummaryPage
    {
        #region WebElements

        static internal By homeIcon = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[1]/a/i");
        static internal By reportsFormsTitle = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[2]/a");
        static internal By qualityIndicatorsMeasuresSummaryTitle = By.XPath("//*[@id='navbar']/header/nav/div[1]/ui-breadcrumbs/ol/li[3]/span");
        static internal By notificationBellIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[1]/i");
        static internal By syncStatusIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[3]/i");
        static internal By profileIcon = By.XPath("//*[@id='navbar']/header/nav/div[2]/div/div[5]/div/img");
        static internal By pageHeaderIcon = By.XPath("//*[@id='main-content']/div/div/header/h1/i");
        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/div/header/h1");
        static internal By selectDateFilter = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[1]/div/div/input");
        static internal By applyButton = By.XPath("//*[@id='mds']/div[4]/div[3]/div/button[1]");
        static internal By cancelButton = By.XPath("//*[@id='mds']/div[4]/div[3]/div/button[2]");
        static internal By printButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[2]/button[1]");
        static internal By wordButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[2]/button[2]");
        static internal By createReportButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[3]/button");
        static internal By mdsFacilityLevelQualityMeasureReportTitle = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/h2");
        static internal By facilityIDLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[1]/td[1]");
        static internal By reportPeriodLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[1]/td[2]");
        static internal By facilityNameLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[2]/td[1]");
        static internal By runDateLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[2]/td[2]");
        static internal By cityStateLabel = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/table/tbody/tr[3]/td[1]");
        static internal By mesureLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[1]");
        static internal By measureIDLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[2]");
        static internal By dataLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[3]");
        static internal By numLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[4]");
        static internal By denomLabel = By.XPath("//*[@id='divToPrint']/thead/tr[2]/th[5]");
        static internal By privacyProtectedDataMessage = By.XPath("//*[@id='divToPrint']/tbody/tr[3]/td/h3");
        static internal By caribouCLSSuiteFooter = By.XPath("//*[@id='footer']/span[1]");
        static internal By versionFooter = By.XPath("//*[@id='footer']/span[2]");
        static internal By userFooter = By.XPath("//*[@id='footer']/span[3]");
        static internal By developedByFooter = By.XPath("//*[@id='footer']/span[4]");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.IsPresent(homeIcon);
            VerifyElement.TitleIsPresent("Caribou CLC Suite Quality Indicators & Measures Summary");
            VerifyElement.AreEqual(reportsFormsTitle, "Reports & Forms");
            VerifyElement.AreEqual(qualityIndicatorsMeasuresSummaryTitle, "Quality Indicators & Measures Summary");
            VerifyElement.IsPresent(notificationBellIcon);
            VerifyElement.IsPresent(syncStatusIcon);
            VerifyElement.IsPresent(profileIcon);
            VerifyElement.AreEqual(pageHeader, "Quality Measures Summary");
            VerifyElement.IsPresent(selectDateFilter);
            Driver.ClickOn(selectDateFilter);
            VerifyElement.IsPresent(applyButton);
            VerifyElement.IsPresent(cancelButton);
            VerifyElement.IsPresent(printButton);
            VerifyElement.IsPresent(wordButton);
            VerifyElement.IsPresent(createReportButton);
            VerifyElement.AreEqual(mdsFacilityLevelQualityMeasureReportTitle, "MDS 3.0 Facility Level Quality Measure Report");
            VerifyElement.IsPresent(facilityIDLabel);
            VerifyElement.IsPresent(reportPeriodLabel);
            VerifyElement.IsPresent(facilityNameLabel);
            VerifyElement.IsPresent(runDateLabel);
            VerifyElement.IsPresent(cityStateLabel);
            VerifyElement.IsPresent(mesureLabel);
            VerifyElement.IsPresent(measureIDLabel);
            VerifyElement.IsPresent(dataLabel);
            VerifyElement.IsPresent(numLabel);
            VerifyElement.IsPresent(denomLabel);
            VerifyElement.AreEqual(privacyProtectedDataMessage, "This report may contain privacy protected data and should not be released to public.");
            VerifyElement.IsPresent(caribouCLSSuiteFooter);
            VerifyElement.IsPresent(versionFooter);
            VerifyElement.IsPresent(userFooter);
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