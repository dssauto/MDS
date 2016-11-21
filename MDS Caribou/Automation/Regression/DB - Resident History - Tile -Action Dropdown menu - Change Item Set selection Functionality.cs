using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class DB___Resident_History___Tile__Action_Dropdown_menu___Change_Item_Set_selection_Functionality : BaseSetup
    {
        [Test]
        public void DB_Resident_History___Tile__Action_Dropdown_menu___Change_Item_Set_selection_Functionality()
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
            //Step 5  Select Change Item Set from Action drop down.
            Driver.ClickOn(SearchResidentsPage.actionInactiveBtn);
            Driver.ClickOn(SearchResidentsPage.changeItemSet);
            //Step 6  Change ItemSet to selected assessment and click CREATE button
            Driver.ClickOn(By.XPath("//button[@ng-click='close()']"));
        }
    }
}
