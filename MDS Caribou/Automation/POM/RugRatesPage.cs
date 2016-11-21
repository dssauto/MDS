using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class RugRatesPage
    {
        #region WebElements

        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/header/h1");
        static internal By ratesLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[1]/span");
        static internal By ruralFilterButton = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[2]/div[1]/div/div/label[1]");
        static internal By urbanFilterButton = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[2]/div[1]/div/div/label[2]");
        static internal By selectYearScrollBar = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[2]/div[2]/ul/li[1]/div/a");
        static internal By fiscalYearColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/table/thead/tr/th[2]");
        static internal By rugIVCategoryColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/table/thead/tr/th[3]");
        static internal By nonCaseMixComponentColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/table/thead/tr/th[4]");
        static internal By nonCaseMixTherapyComponentColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/table/thead/tr/th[5]");
        static internal By nursingComponentColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/table/thead/tr/th[6]");
        static internal By nursingIndexColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/table/thead/tr/th[7]");
        static internal By therapyComponentColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/table/thead/tr/th[8]");
        static internal By therapyIndexColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/table/thead/tr/th[9]");
        static internal By totalRateColumnLabel = By.XPath("//*[@id='main-content']/div/div/div/div/div/table/thead/tr/th[10]");
        static internal By previousButton = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[4]/ul/li[1]/a");
        static internal By nextButton = By.XPath("//*[@id='main-content']/div/div/div/div/div/div[4]/ul/li[9]/a");


        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("Caribou CLC Suite");
            VerifyElement.AreEqual(pageHeader, "$ RUG-IV 66 Grouper");
            VerifyElement.IsPresent(ratesLabel);
            VerifyElement.IsPresent(ruralFilterButton);
            VerifyElement.IsPresent(urbanFilterButton);
            VerifyElement.IsPresent(selectYearScrollBar);
            VerifyElement.AreEqual(fiscalYearColumnLabel, "Fiscal Year");
            VerifyElement.AreEqual(rugIVCategoryColumnLabel, "RUG-IV Category");
            VerifyElement.AreEqual(nonCaseMixComponentColumnLabel, "NonCase Mix Component");
            VerifyElement.AreEqual(nonCaseMixTherapyComponentColumnLabel, "NonCase Mix Therapy Component");
            VerifyElement.AreEqual(nursingComponentColumnLabel, "Nursing Component");
            VerifyElement.AreEqual(nursingIndexColumnLabel, "Nursing Index");
            VerifyElement.AreEqual(therapyComponentColumnLabel, "Therapy Component");
            VerifyElement.AreEqual(therapyIndexColumnLabel, "Therapy Index");
            VerifyElement.AreEqual(totalRateColumnLabel, "Total Rate");
            VerifyElement.IsPresent(previousButton);
            VerifyElement.IsPresent(nextButton);
        }
        #endregion

        #region Navigation


        #endregion
    }
}