using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace Automation.Regression
{
    [TestFixture]
    class CU___Resident_History_Tile___Selecting_resident_tile_displays_resident_history_information : BaseSetup
    {
        [Test]
        public void CU_Resident_History_Tile___Selecting_resident_tile_displays_resident_history_information()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile.
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Click SEARCH button
            Driver.PressEnter(SearchResidentsPage.searchButton);
            int residents = Driver.Instance.FindElements(By.XPath("//li[@class='list-group-item ng-scope']")).Count;
            TestReport.Log(LogStatus.Pass, residents + " Residents are displayed.");
            //Step 3  Select resident tile from the FIRST page
            SearchResidentsPage.NavigateToResidentsHistoryPage();
            //Step 5  Click Search Residents link
            Driver.ClickOn(UserMenu.searchResidentsNavbarLink);
            //Step 6  Click SEARCH button
            Driver.ClickOn(SearchResidentsPage.searchButton);
            //Step 7  Click Last page
            SearchResidentsPage.NavigateToLastPage();
            //Step 8  Select resident tile from the Last page
            SearchResidentsPage.NavigateToResidentsHistoryPage();
            //Step 9  Click Search Residents link
            Driver.ClickOn(UserMenu.searchResidentsNavbarLink);
            //Step 10 Click SEARCH button
            Driver.ClickOn(SearchResidentsPage.searchButton);
            //Step 11 Click Second page
            SearchResidentsPage.NavigateToSecondPage();
            //Step 12 Select resident tile from the Second page
            SearchResidentsPage.NavigateToResidentsHistoryPage();
        }
    }
}
