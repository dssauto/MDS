using Automation.POM;
using Framework.Base;
using Framework.POM;
using NUnit.Framework;

namespace Automation.Regression
{
    [TestFixture]
    class CT___Resident_History_Tile___Resident_History_Tile_information_displays_on_resident_tile_Room_Bed_Neighborhood_SSN_Full_name : BaseSetup
    {
        [Test]
        public void CT_Resident_History_Tile___Resident_History_Tile_information_displays_on_resident_tile_Room_Bed_Neighborhood_SSN_Full_name()
        {
            Browser.Open();
            LoginPage.SignIn();
            //Step 1  Select Resident History tile
            LandingPage.NavigateToResidentHistoryPage();
            //Step 2  Click drop down selection for  "Select Neighborhood"  field
            //Step 3  Click All Neighborhoods
            Driver.SelectDropdown(SearchResidentsPage.selectLocationDropdown, "All Neighborhoods");
            //Step 4  Verify that Resident History Tile information displays on residents tile Full name
            VerifyElement.IsPresent(SearchResidentsPage.searchResultFirstname);
            VerifyElement.IsPresent(SearchResidentsPage.searchResultLastname);
            //Step 5  Verify that Resident History Tile information displays on residents tile Neighborhood
            VerifyElement.IsPresent(SearchResidentsPage.neighborhood);
            //Step 6  Verify that Resident History Tile information displays on residents tile Room and Bed
            VerifyElement.IsPresent(SearchResidentsPage.roomandBed);
            //Step 7  Verify that Resident History Tile information displays on residents tile last four SSN
            VerifyElement.IsPresent(SearchResidentsPage.lastSSN);
        }
    }
}
