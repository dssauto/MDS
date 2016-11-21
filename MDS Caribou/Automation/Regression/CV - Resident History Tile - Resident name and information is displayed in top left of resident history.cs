using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace Automation.Regression
{
    [TestFixture]
    class CV___Resident_History_Tile___Resident_name_and_information_is_displayed_in_top_left_of_resident_history : BaseSetup
    {
        [Test]
        public void CV_Resident_History_Tile_Resident_name_and_information_is_displayed_in_top_left_of_resident_history()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Select Resident History tile
            LandingPage.NavigateToResidentHistoryPage();
            //Click SEARCH button
            Driver.ClickOn(SearchResidentsPage.searchButton);
            //Select resident tile from the FIRST page
            SearchResidentsPage.NavigateToResidentsHistoryPage();
            //Verify that resident name and information is displayed in top left of resident history
            Driver.WaitForElement(ResidentsHistoryPage.createNewMDSBtn);
            string residentTop = Driver.Instance.FindElement(By.XPath("(//span[@class='ng-binding'])[1]")).Text.ToString();
            string residentTile = Driver.Instance.FindElement(By.XPath("//h3[@class='clickable ng-binding']")).Text.ToString();
            Assert.AreEqual(residentTop, residentTile + " History");
            TestReport.Log(LogStatus.Pass, residentTop + " name displayed correctly");
            //Click Search Residents link
            Driver.ClickOn(UserMenu.searchResidentsNavbarLink);
            //Click SEARCH button
            Driver.ClickOn(SearchResidentsPage.searchButton);
            //Select resident tile from the Last page
            SearchResidentsPage.NavigateToLastPage();
            SearchResidentsPage.NavigateToResidentsHistoryPage();
            //Verify that resident name and information is displayed in top left of resident history
            Driver.WaitForElement(ResidentsHistoryPage.createNewMDSBtn);
            string residentTop2 = Driver.Instance.FindElement(By.XPath("(//span[@class='ng-binding'])[1]")).Text.ToString();
            string residentTile2 = Driver.Instance.FindElement(By.XPath("//h3[@class='clickable ng-binding']")).Text.ToString();
            Assert.AreEqual(residentTop2, residentTile2 + " History");
            TestReport.Log(LogStatus.Pass, residentTop2 + " name displayed correctly");
            //Click Search Residents link
            Driver.ClickOn(UserMenu.searchResidentsNavbarLink);
            //Click SEARCH button
            Driver.ClickOn(SearchResidentsPage.searchButton);
            //Click Second page
            SearchResidentsPage.NavigateToSecondPage();
            SearchResidentsPage.NavigateToResidentsHistoryPage();
            //Verify that resident name and information is displayed in top left of resident history
            Driver.WaitForElement(ResidentsHistoryPage.createNewMDSBtn);
            string residentTop3 = Driver.Instance.FindElement(By.XPath("(//span[@class='ng-binding'])[1]")).Text.ToString();
            string residentTile3 = Driver.Instance.FindElement(By.XPath("//h3[@class='clickable ng-binding']")).Text.ToString();
            Assert.AreEqual(residentTop3, residentTile3 + " History");
            TestReport.Log(LogStatus.Pass, residentTop3 + " name displayed correctly");
        }
    }
}
