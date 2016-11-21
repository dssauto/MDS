using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class DC___Resident_History___Schedule_Tile___Schedule__Accuracy___Quarterly_and_Annual_slider_bar_settings : BaseSetup
    {
        [Test]
        public void DC_Resident_History___Schedule_Tile___Schedule__Accuracy___Quarterly_and_Annual_slider_bar_settings()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Click SEARCH button
            //Step 3  Select resident tile from the FIRST page
            SearchResidentsPage.FindResidentWithAssessment();
            //Step 4  Select the radio button to to the left of any assessment.
            Driver.ClickOn(By.XPath("(//div[@class='iradio_square-blue'])[1]"));
            //Step 5  Select Archive from Action drop down.
            Driver.ClickOn(SearchResidentsPage.actionInactiveBtn);
            Driver.ClickOn(SearchResidentsPage.archive);
            //Step 6  Click YES button
            Driver.ClickOn(By.XPath("//button[@ng-click='close()']"));
        }
    }
}
