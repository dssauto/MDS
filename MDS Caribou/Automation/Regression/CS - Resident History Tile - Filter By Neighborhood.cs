using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace Automation.Regression
{
    [TestFixture]
    class CS___Resident_History_Tile___Filter_By_Neighborhood : BaseSetup
    {
        [Test]
        public void CS_Resident_History_Tile___Filter_By_Neighborhood()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile.
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Click drop down selection for  "Select Neighborhood"  field
            //Step 3  Click one from existing Neighborhood
            Driver.SelectDropdown(SearchResidentsPage.selectLocationDropdown, "RAIMDS2");
            //Step 4  Verify that only Residents with selected Neighborhood displayed on the page.
            VerifyElement.AreEqual(SearchResidentsPage.searchResultLastname, "RAIMDSRESIDENT");
            //Step 5  Click drop down selection for  "Select Neighborhood"  field
            //Step 6  Click another Neighborhood from existing Neighborhood
            Driver.SelectDropdown(SearchResidentsPage.selectLocationDropdown, "RAIMDS3");
            //Step 7  Verify that only Residents with selected Neighborhood displayed on the page.
            VerifyElement.AreEqual(SearchResidentsPage.searchResultLastname, "RAIMDSRESIDENT");
            //Step 8  Click drop down selection for  "Select Neighborhood"  field
            //Step 9  Click All Neighborhoods
            Driver.SelectDropdown(SearchResidentsPage.selectLocationDropdown, "All Neighborhoods");
            Driver.WaitFor(2);
            int residents = Driver.Instance.FindElements(By.XPath("//li[@class='list-group-item ng-scope']")).Count;
            TestReport.Log(LogStatus.Pass, residents + " Residents are displayed.");
            //Step 10 Type in "Select Neighborhood"  field
        }
    }
}
