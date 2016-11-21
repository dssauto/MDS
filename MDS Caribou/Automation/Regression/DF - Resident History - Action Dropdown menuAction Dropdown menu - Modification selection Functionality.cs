using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Regression
{
    [TestFixture]
    class DF___Resident_History___Action_Dropdown_menuAction_Dropdown_menu___Modification_selection_Functionality : BaseSetup
    {
        [Test]
        public void DF_Resident_History___Action_Dropdown_menuAction_Dropdown_menu___Modification_selection_Functionality()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Click SEARCH button
            //Step 3  Select resident tile from the FIRST page with Sealed and Accepted assessment.
            SearchResidentsPage.FindResidentWithAssessment();
            //Step 4  "Select the radio button to to the left of Sealed and Accepted assessment."
            Driver.ClickOn(By.XPath("(//div[@class='iradio_square-blue'])[1]"));
            //Step 5  Select Modification from Action drop down.
            //Step 6  Click CANCEL button
            //Step 7  "Select the radio button to to the left of Sealedand Accepted assessment."
            //Step 8  Select Modification from Action drop down.
            //Step 9  Click YES button
        }
    }
}
