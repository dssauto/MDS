using Framework.POM;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Automation.POM
{
    class ReimbursementPage
    {
        #region WebElements

        static internal By pageHeader = By.XPath("//*[@id='main-content']/div/div/header/h1");
        static internal By selectDateFilter = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/div/div/div/div[1]/div/div/input");
        static internal By applyButton = By.XPath("//*[@id='mds']/div[3]/div[3]/div/button[1]");
        static internal By cancelButton = By.XPath("//*[@id='mds']/div[3]/div[3]/div/button[2]");
        static internal By selectLocationDropdown = By.Id("selectLocation");

        #endregion

        #region Action

        public static void VerifyPageElements()
        {
            VerifyElement.TitleIsPresent("Caribou CLC Suite");
            VerifyElement.AreEqual(pageHeader, " Nursing Index and RUG-IV Reimbursement Report");
            VerifyElement.IsPresent(selectDateFilter);
            VerifyElement.IsPresent(applyButton);
            VerifyElement.IsPresent(cancelButton);
            VerifyElement.IsPresent(selectLocationDropdown);
        }
        #endregion

        #region Navigation

        public static void NavigateTo()
        {
        }
        #endregion

    }
}