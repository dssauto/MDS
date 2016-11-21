using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class CC___WIP___Filter_By_Neighborhood : BaseSetup
    {
        [Test]
        public void CC_WIP___Filter_By_Neighborhood()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Work In Progress tile.
            LandingPage.NavigateToWorkInProgressPage();
            //Step 2  Verify that "Select Neighborhood"  field displayed as a default
            VerifyElement.IsPresent(By.XPath("//*[@id='selectLocation'][contains(., 'Select Neighborhood')]"));
            //Step 3  Click drop down selection for  "Select Neighborhood"  field
            Driver.SelectDropdown(WorkInProgressPage.selectLocationDropdown, "Select Neighborhood");
            //Step 4  Click one from existing Neighborhood
            Driver.SelectDropdown(WorkInProgressPage.selectLocationDropdown, "RAIMDS2");
            //Step 5  Click Residents Name on the Residents Tiles
            //Step 6  Verify that only Residents Assessments with selected Neighborhood displayed on the Work In Progress page.


            //Step 7  Click drop down selection for  "Select Neighborhood"  field
            //Step 8  Click "Select Neighborhood"
            Driver.SelectDropdown(WorkInProgressPage.selectLocationDropdown, "Select Neighborhood");
            //Step 9  Type in "Select Neighborhood"  field
        }
    }
}
