using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class CZ___Resident_History_Tile___Action_Dropdown_Menu___Edit_selection_Functionality : BaseSetup
    {
        [Test]
        public void CZ_Resident_History_Tile___Action_Dropdown_Menu___Edit_selection_Functionality()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Click SEARCH button
            //Step 3  Select resident tile from the FIRST page
            //Step 4  Select the radio button to to the left of any assessment.
            SearchResidentsPage.FindResidentWithAssessment();
            Driver.ClickOn(By.XPath("(//div[@class='iradio_square-blue'])[1]"));
            Driver.WaitFor(1);
            //Step 5  Select Edit from Action drop down.
            Driver.ClickOn(SearchResidentsPage.actionInactiveBtn);
            Driver.ClickOn(By.XPath("(//a[@class='ng-scope'])[2]"));
            Driver.WaitForElement(By.XPath("//button[@class='btn btn-default dropdown-toggle']"));
            VerifyElement.AreEqual(UserMenu.assessmentNavbar, "Assessment");
        }
    }
}