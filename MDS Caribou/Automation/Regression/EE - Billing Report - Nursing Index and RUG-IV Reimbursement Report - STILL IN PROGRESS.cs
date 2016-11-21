using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class EE___Billing_Report___Nursing_Index_and_RUG_IV_Reimbursement_Report___STILL_IN_PROGRESS : BaseSetup
    {
        [Test]
        public void EE_Billing_Report___Nursing_Index_and_RUG_IV_Reimbursement_Report___STILL_IN_PROGRESS()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Reports &Forms Tile.
            LandingPage.NavigateToReportsFormsPage();
            //Step 2  "Select the Billing option in the left hand navigation menu.
            DashboardPage.NavigateToBilling();
            //Dropdown is then displayed with Billing option. 
            //Select the Billing option from the report."
            DashboardPage.NavigateToRUGIV();
            //Step 3  Select the Date Range text field.
            Driver.ClickOn(By.XPath("(//input[@type='text'])[1]"));
            //Step 4  Select a 'To' and 'From' date range that the assessments ARD falls into.
            Driver.InsertText(By.XPath("(//input[@type='text'])[2]"), "2016-10-10");
            Driver.InsertText(By.XPath("(//input[@type='text'])[3]"), "2017-10-10");
            //Step 5  Click the Apply button.
            Driver.ClickOn(By.XPath("//button[@class='applyBtn btn btn-small btn-sm btn-primary']"));
        }
    }
}

