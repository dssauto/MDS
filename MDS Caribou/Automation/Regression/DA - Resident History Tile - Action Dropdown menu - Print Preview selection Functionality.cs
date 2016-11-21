using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class DA___Resident_History_Tile___Action_Dropdown_menu___Print_Preview_selection_Functionality : BaseSetup
    {
        [Test]
        public void DA_Resident_History_Tile___Action_Dropdown_menu___Print_Preview_selection_Functionality()
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
            Driver.WaitFor(1);
            //Step 5  Select Print Preview from Action drop down.
            Driver.ClickOn(SearchResidentsPage.actionInactiveBtn);
            //Step 6  Click PRINT button
            Driver.ClickOn(By.XPath("//a[@ng-click='previewAssessment()']"));
            VerifyElement.IsPresent(By.XPath("//button[@dss-print='']"));
        }
    }
}
