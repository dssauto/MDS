using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class QualityMeasuresLongStayDetailsPage
    {
        #region WebElements

        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/div/header/h1");
        static internal By selectDateFilter = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[1]/div/div/input");
        static internal By applyButton = By.XPath("//*[@id='mds']/div[4]/div[3]/div/button[1]");
        static internal By cancelButton = By.XPath("//*[@id='mds']/div[4]/div[3]/div/button[2]");
        static internal By printButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[2]/button[1]");
        static internal By wordButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[2]/button[2]");
        static internal By createReportButton = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div[3]/button");
        static internal By mdsLongStayTitle = By.XPath("//*[@id='divToPrint']/thead/tr[1]/th/h2");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("Caribou CLC Suite");
            VerifyElement.AreEqual(pageHeader, "Quality Measures Long Stay Details");
            VerifyElement.IsPresent(selectDateFilter);
            VerifyElement.IsPresent(applyButton);
            VerifyElement.IsPresent(cancelButton);
            VerifyElement.IsPresent(printButton);
            VerifyElement.IsPresent(wordButton);
            VerifyElement.IsPresent(createReportButton);
            VerifyElement.AreEqual(mdsLongStayTitle, "MDS 3.0 Facility Level Quality Measure Report - Resident Detail (Long Stay)");
        }

        #endregion

        #region Navigation

        public static void NavigateTo()
        {
        }
        #endregion

    }
}