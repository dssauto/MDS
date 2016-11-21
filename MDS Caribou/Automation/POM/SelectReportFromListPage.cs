using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class SelectReportFromListPage
    {
        #region WebElements

        static internal By pageHeader = By.XPath("//*[@id='mds']/div[1]/div/div/div[1]/h3");
        static internal By badgeIcon = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/table/thead/tr/td[1]/span");
        static internal By reportDateLabel = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/table/thead/tr/td[2]");
        static internal By userNameLabel = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/table/thead/tr/td[3]");
        static internal By titleLabel = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/table/thead/tr/td[4]");
        static internal By iCheckHelperLabel = By.XPath("//*[@id='mds']/div[1]/div/div/div[2]/div/div[1]/table/tbody/tr/td[1]/div/label");
        static internal By cancelButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/button[1]");
        static internal By confirmButton = By.XPath("//*[@id='mds']/div[1]/div/div/div[3]/button[2]");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.AreEqual(pageHeader, "Select report from list");
            VerifyElement.IsPresent(badgeIcon);
            VerifyElement.AreEqual(reportDateLabel, "Report Date");
            VerifyElement.AreEqual(userNameLabel, "User Name");
            VerifyElement.AreEqual(titleLabel, "Title");
            VerifyElement.IsPresent(iCheckHelperLabel);
            VerifyElement.IsPresent(cancelButton);
            VerifyElement.IsPresent(confirmButton);
        }

        #endregion

    }
}