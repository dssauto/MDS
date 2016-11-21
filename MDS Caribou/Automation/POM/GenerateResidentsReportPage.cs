using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class GenerateResidentsReportPage
    {
        #region WebElements

        static internal By generateResidentsReportHeader = By.XPath("//*[@id='mds']/div[1]/div/div/div[1]/h3");
        static internal By selectLocationDropdown = By.Id("selectLocation");
        static internal By cancelButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/button[1]");
        static internal By confirmButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/button[2]");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.AreEqual(generateResidentsReportHeader, "Generate Residents Report");
            VerifyElement.IsPresent(selectLocationDropdown);
            VerifyElement.IsPresent(cancelButton);
            VerifyElement.IsPresent(confirmButton);
        }
        #endregion
    }
}